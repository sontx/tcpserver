using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    internal class ClientWrapper
    {
        public event EventHandler Closed;

        public event ReceivedDataEventHandler ReceivedData;

        private readonly NetworkStream stream;
        private bool triggeredClosedEvent;
        private readonly object triggeredClosedEventLock = new object();

        public TcpClient Client { get; }
        public Action<Exception> ErrorHandler { get; set; }

        public ClientWrapper(TcpClient client)
        {
            Client = client;
            client.ReceiveBufferSize = ushort.MaxValue;
            stream = client.GetStream();
            WaitForIncommingData();
        }

        private async void WaitForIncommingData()
        {
            var buffer = new byte[100000];
            try
            {
                while (Client.Connected)
                {
                    var readLength = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (readLength > 0)
                    {
                        var actualBytes = new byte[readLength];
                        Array.Copy(buffer, 0, actualBytes, 0, actualBytes.Length);
                        ReceivedData?.Invoke(this, new ReceivedDataEventArgs { Data = actualBytes });
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch { }
            finally
            {
                TriggerClosedEvent();
            }
        }

        public void Disconnect()
        {
            lock (stream)
            {
                Client.Close();
                stream.Close();
                TriggerClosedEvent();
            }
        }

        private void TriggerClosedEvent()
        {
            lock (triggeredClosedEventLock)
            {
                if (triggeredClosedEvent) return;
                triggeredClosedEvent = true;
                Closed?.Invoke(this, EventArgs.Empty);
            }
        }

        public Task SendText(string text)
        {
            return SendBytes(Encoding.ASCII.GetBytes(text));
        }

        public async Task SendHex(string hex)
        {
            hex = hex.Replace(" ", "").Replace("-", "");
            if (hex.Length % 2 == 0)
            {
                var buffer = new byte[hex.Length / 2];
                for (int i = 0, j = 0; i < hex.Length - 1; i += 2, j++)
                {
                    var st = hex.Substring(i, 2);
                    buffer[j] = (byte)Convert.ToInt32(st, 16);
                }
                await SendBytes(buffer);
            }
        }

        private Task SendBytes(byte[] bytes)
        {
            return Task.Run(() =>
            {
                try
                {
                    lock (stream)
                    {
                        stream.Write(bytes, 0, bytes.Length);
                    }
                }
                catch (Exception ex)
                {
                    TriggerClosedEvent();
                    ErrorHandler?.Invoke(ex);
                }
            });
        }
    }
}