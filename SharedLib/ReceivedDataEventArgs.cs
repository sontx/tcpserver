using System;

namespace SharedLib
{
    public delegate void ReceivedDataEventHandler(object sender, ReceivedDataEventArgs e);

    public class ReceivedDataEventArgs : EventArgs
    {
        public byte[] Data { get; set; }
    }
}