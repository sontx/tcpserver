using SharedLib;
using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Emulator
{
    public partial class MainForm : Form
    {
        private ClientWrapper client;
        private bool stopped;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            client?.Disconnect();
            base.OnFormClosed(e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                stopped = false;
                labError.Text = string.Empty;
                DoStart();
            }
            else
            {
                stopped = true;
                btnStart.Text = "Start";
                DoStop();
            }
        }

        private void DoStop()
        {
            client?.Disconnect();
        }

        private async void DoStart()
        {
            try
            {
                gbConnection.Enabled = false;
                txtContent.Text = string.Empty;

                txtLogs.Text = string.Empty;
                var tcpClient = new TcpClient();
                tcpClient.ReceiveBufferSize = ushort.MaxValue;
                await tcpClient.ConnectAsync(txtIP.Text, int.Parse(txtPort.Text));
                client = new ClientWrapper(tcpClient);

                btnStart.Text = "Stop";
                gbSendData.Enabled = true;
                client.ReceivedData += Client_ReceivedData;
                client.Closed += Client_Closed;
            }
            catch (Exception ex)
            {
                if (!stopped)
                    labError.Text = ex.Message;
                ResetState();
            }
        }

        private void Client_Closed(object sender, EventArgs e)
        {
            client?.Disconnect();
            ResetState();
        }

        private void ResetState()
        {
            btnStart.Text = "Start";
            gbSendData.Enabled = false;
            gbConnection.Enabled = true;
        }

        private void Client_ReceivedData(object sender, ReceivedDataEventArgs e)
        {
            var formattedText = Utils.FormatReceivedData(e.Data, SpaceBetweenElements.Space, DisplayMode.Hex);
            txtLogs.AppendText(formattedText + Environment.NewLine);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var content = txtContent.Text.Trim();
            if (string.IsNullOrEmpty(content)) return;

            gbSendData.Enabled = false;
            if (rbString.Checked)
                await client.SendText(content);
            else if (content.Length % 2 != 0)
                labError.Text = "Number of characters should be an even number";
            else
                await client.SendHex(content);
            gbSendData.Enabled = true;
        }
    }
}