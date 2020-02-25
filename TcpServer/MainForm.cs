using Blackcat.Configuration;
using Blackcat.WinForm;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace TcpServer
{
    public partial class MainForm : BaseForm
    {
        private readonly AppSettings settings;
        private TcpListener listener;
        private bool stopped;

        public MainForm()
        {
            InitializeComponent();
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            settings = ConfigLoader.Default.Get<AppSettings>();
            lvClients.Columns[4].Width = -2;
            ClearStatusBar();
        }

        private void mnStart_Click(object sender, EventArgs e)
        {
            try
            {
                stopped = false;
                ListenOn(settings.Port);
                mnStop.Enabled = true;
                mnStart.Enabled = false;
                mnSendHexAll.Enabled = true;
                mnSendTextAll.Enabled = true;
            }
            catch (Exception ex)
            {
                if (!stopped)
                    ShowText(labError, ex.Message);
            }
        }

        private void ListenOn(int port)
        {
            listener?.Stop();
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start(int.MaxValue);
            ClearStatusBar();
            ShowText(labStatus, $"[Listening on {port}]");
            lvClients.Items.Clear();
            WaitForConnection();
        }

        private async void WaitForConnection()
        {
            try
            {
                while (!stopped)
                {
                    var client = await listener.AcceptTcpClientAsync();
                    var item = new ListViewItem((lvClients.Items.Count + 1).ToString());
                    var endpoint = client.Client.RemoteEndPoint as IPEndPoint;
                    item.SubItems.Add(endpoint.Address.ToString());
                    item.SubItems.Add(endpoint.Port.ToString());
                    item.SubItems.Add(DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"));
                    item.SubItems.Add("");
                    var wrapper = new ClientWrapper(client);
                    wrapper.Closed += Wrapper_Closed;
                    wrapper.ReceivedData += Wrapper_ReceivedData;
                    item.Tag = wrapper;
                    lvClients.Items.Add(item);
                    UpdateConnectionCount();
                }
            }
            catch (Exception ex)
            {
                if (!stopped)
                    ShowText(labError, ex.Message);
            }
        }

        private void Wrapper_ReceivedData(object sender, ReceivedDataEventArgs e)
        {
            foreach (ListViewItem item in lvClients.Items)
            {
                if (item.Tag == sender)
                {
                    ShowReceivedDataOnItem(item, e.Data);
                    break;
                }
            }
        }

        private void ShowReceivedDataOnItem(ListViewItem item, byte[] bytes)
        {
            var displayText = Utils.FormatReceivedData(bytes, settings.SpaceBetweenElements, settings.DisplayMode);
            var subItem = item.SubItems[4];
            subItem.Text = displayText;
            subItem.Tag = bytes;
        }

        private void ShowText(ToolStripStatusLabel label, string text)
        {
            label.Text = text;
            label.Visible = !string.IsNullOrEmpty(text);
        }

        private void UpdateConnectionCount()
        {
            ShowText(labClients, $"[{lvClients.Items.Count} connected client" + (lvClients.Items.Count > 1 ? "s]" : "]"));
        }

        private void Wrapper_Closed(object sender, EventArgs e)
        {
            InvokerHost.Invoke(() =>
            {
                var items = lvClients.Items;
                ListViewItem foundItem = null;
                foreach (ListViewItem item in items)
                {
                    if (item.Tag == sender)
                    {
                        foundItem = item;
                        break;
                    }
                }

                if (foundItem != null)
                {
                    lvClients.Items.Remove(foundItem);
                    var wrapper = sender as ClientWrapper;
                    wrapper.Closed -= Wrapper_Closed;
                    wrapper.ReceivedData -= Wrapper_ReceivedData;
                    UpdateConnectionCount();
                }
            });
        }

        private void mnStop_Click(object sender, EventArgs e)
        {
            if (MessageBoxHost.ShowQuestion("Are you sure you want to stop listening and disconnect all clients?"))
            {
                stopped = true;
                var wrappers = new List<ClientWrapper>();
                foreach (ListViewItem item in lvClients.Items)
                {
                    wrappers.Add(item.Tag as ClientWrapper);
                }
                wrappers.ForEach(wrapper => wrapper.Disconnect());
                listener?.Stop();
                mnStop.Enabled = false;
                mnStart.Enabled = true;
                mnSendHexAll.Enabled = false;
                mnSendTextAll.Enabled = false;
                ClearStatusBar();
            }
        }

        private void ClearStatusBar()
        {
            ShowText(labStatus, string.Empty);
            ShowText(labError, string.Empty);
            ShowText(labClients, string.Empty);
        }

        private void mnSettings_Click(object sender, EventArgs e)
        {
            if (settings.ShowEditor(true, this))
            {
                foreach (ListViewItem item in lvClients.Items)
                {
                    var subItem = item.SubItems[4];
                    if (subItem.Tag is byte[] bytes)
                    {
                        ShowReceivedDataOnItem(item, bytes);
                    }
                }
            }
        }

        private void lvClients_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = lvClients.SelectedItems.Count > 0 ? lvClients.SelectedItems[0] : null;
            if (selectedItem != null)
            {
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvClients.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private List<ClientWrapper> GetClientWrapperList(System.Collections.IList collection)
        {
            var list = new List<ClientWrapper>();
            foreach (ListViewItem item in collection)
            {
                list.Add(item.Tag as ClientWrapper);
            }
            return list;
        }

        private void mnSendText_Click(object sender, EventArgs e)
        {
            SendToClients(GetClientWrapperList(lvClients.SelectedItems), false);
        }

        private void SendToClients(List<ClientWrapper> clients, bool hex)
        {
            var form = new SendForm();
            form.SetMode(hex);
            form.Clients = clients;
            form.Show(this);
        }

        private void mnSendHex_Click(object sender, EventArgs e)
        {
            SendToClients(GetClientWrapperList(lvClients.SelectedItems), true);
        }

        private void mnDisconnect_Click(object sender, EventArgs e)
        {
            if (MessageBoxHost.ShowQuestion("Are you sure you want to disconnect all selected clients?"))
            {
                var selectedClients = GetClientWrapperList(lvClients.SelectedItems);
                selectedClients.ForEach(client => client.Disconnect());
            }
        }

        private void mnSendTextAll_Click(object sender, EventArgs e)
        {
            if (lvClients.CheckedItems.Count > 0)
            {
                SendToClients(GetClientWrapperList(lvClients.CheckedItems), false);
            }
        }

        private void mnSendHexAll_Click(object sender, EventArgs e)
        {
            if (lvClients.CheckedItems.Count > 0)
            {
                SendToClients(GetClientWrapperList(lvClients.CheckedItems), true);
            }
        }

        private void DoOnSelectedItem(Action<ListViewItem> action)
        {
            var selectedItem = lvClients.SelectedItems.Count > 0 ? lvClients.SelectedItems[0] : null;
            if (selectedItem != null)
            {
                action(selectedItem);
            }
        }

        private void mnCopyAddress_Click(object sender, EventArgs e)
        {
            DoOnSelectedItem(item =>
            {
                var wrapper = item.Tag as ClientWrapper;
                var endpoint = wrapper.Client.Client.RemoteEndPoint;
                Clipboard.SetText(endpoint.ToString());
            });
        }

        private void mnCopyReceivedData_Click(object sender, EventArgs e)
        {
            DoOnSelectedItem(item =>
            {
                var subItem = item.SubItems[4];
                if (subItem.Tag is byte[] bytes)
                {
                    var formattedText = Utils.FormatReceivedData(bytes, settings.SpaceBetweenElements, settings.DisplayMode);
                    Clipboard.SetText(formattedText);
                }
            });
        }

        private void mnShowIncommingData_Click(object sender, EventArgs e)
        {
            var list = GetClientWrapperList(lvClients.SelectedItems);
            foreach (var client in list)
            {
                var form = new IncommingDataForm();
                form.Client = client;
                form.Show(this);
            }
        }
    }
}