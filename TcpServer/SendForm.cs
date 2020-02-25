using Blackcat.WinForm;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TcpServer
{
    public partial class SendForm : ChooserForm
    {
        private static readonly int[] intervals = new int[] { 1000, 2000, 3000, 4000, 5000, 10000 };

        private bool hexMode;
        private string content;
        private List<ClientWrapper> clients = new List<ClientWrapper>();

        internal List<ClientWrapper> Clients
        {
            get => clients;
            set
            {
                clients = value;
                foreach (var client in clients)
                {
                    client.ErrorHandler = HandleError;
                }
                labMessage.Text = $"Send to {clients.Count} " + (clients.Count > 1 ? "clients" : "client");
            }
        }

        public SendForm()
        {
            InitializeComponent();
            btnOK.Text = "Send";
            btnCancel.Text = "Close";
            cbbMode.SelectedIndex = 0;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            foreach (var client in Clients)
            {
                client.ErrorHandler = null;
            }
        }

        private void HandleError(Exception ex)
        {
            InvokerHost.Invoke(() =>
            {
                labError.Text = ex.Message;
            });
        }

        public void SetMode(bool hex)
        {
            hexMode = hex;
            base.Text = hex ? "Send Hex" : "Send Text";
        }

        protected override bool OnAccept()
        {
            if (btnOK.Text == "Send")
            {
                var content = txtContent.Text.Trim();
                if (!string.IsNullOrEmpty(content))
                    DoWork(content);
            }
            else if (btnOK.Text == "Stop")
            {
                timer1.Stop();
                pnlWorkingSpace.Enabled = true;
                btnOK.Text = "Send";
            }
            return false;
        }

        private async void DoWork(string content)
        {
            if (hexMode && content.Length % 2 != 0)
            {
                MessageBoxHost.ShowError("Number of characters should be an even number");
                return;
            }

            labError.Text = string.Empty;
            if (cbbMode.SelectedIndex == 0)
                await SendOnce(content);
            else
                SendEvery(content, intervals[cbbMode.SelectedIndex - 1]);
        }

        private async Task SendOnce(string content)
        {
            pnlWorkingSpace.Enabled = false;
            btnOK.Enabled = false;
            await DoSend(content);
            btnOK.Enabled = true;
            pnlWorkingSpace.Enabled = true;
        }

        private void SendEvery(string content, int interval)
        {
            pnlWorkingSpace.Enabled = false;
            btnOK.Text = "Stop";
            this.content = content.Trim();
            timer1.Interval = interval;
            timer1.Start();
        }

        private async Task DoSend(string content)
        {
            if (hexMode)
            {
                foreach (var client in Clients)
                {
                    await client.SendHex(content);
                }
            }
            else
            {
                foreach (var client in Clients)
                {
                    await client.SendText(content);
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await DoSend(content);
        }
    }
}