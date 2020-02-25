using Blackcat.Configuration;
using SharedLib;
using System.ComponentModel;

namespace TcpServer
{
    [ConfigClass(Key = "App")]
    internal class AppSettings
    {
        [Description("Port to listen")]
        public int Port { get; set; } = 3393;

        [Description("Display received data as")]
        public DisplayMode DisplayMode { get; set; }

        [Description("Space between elements")]
        public SpaceBetweenElements SpaceBetweenElements { get; set; }
    }
}