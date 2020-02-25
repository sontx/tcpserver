using Blackcat.Configuration;
using Blackcat.WinForm;
using SharedLib;
using System;
using System.Windows.Forms;

namespace TcpServer
{
    public partial class IncommingDataForm : ChooserForm
    {
        private readonly AppSettings settings;

        private ClientWrapper client;

        internal ClientWrapper Client
        {
            get => client;

            set
            {
                client = value;
                client.ReceivedData += Client_ReceivedData;
            }
        }

        public IncommingDataForm()
        {
            InitializeComponent();
            btnOK.Visible = false;
            btnCancel.Text = "Close";
            settings = ConfigLoader.Default.Get<AppSettings>();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            client.ReceivedData -= Client_ReceivedData;
        }

        private void Client_ReceivedData(object sender, ReceivedDataEventArgs e)
        {
            InvokerHost.Invoke(() =>
            {
                var formattedText = Utils.FormatReceivedData(e.Data, settings.SpaceBetweenElements, settings.DisplayMode);
                txtLogs.AppendText($"[{DateTime.Now:HH:mm:ss:sss}] {formattedText}{Environment.NewLine}");
            });
        }
    }
}