using System;
using System.Text;

namespace SharedLib
{
    public static class Utils
    {
        public static string FormatReceivedData(byte[] bytes, SpaceBetweenElements spaceBetween, DisplayMode displayMode)
        {
            var space = "";
            if (spaceBetween == SpaceBetweenElements.Minus)
                space = "-";
            else if (spaceBetween == SpaceBetweenElements.Space)
                space = " ";

            var displayText = "";
            if (displayMode == DisplayMode.Dec)
                displayText = string.Join(space, bytes);
            else if (displayMode == DisplayMode.Hex)
                displayText = BitConverter.ToString(bytes).Replace("-", space);
            else if (displayMode == DisplayMode.String)
                displayText = Encoding.ASCII.GetString(bytes);
            return displayText;
        }
    }
}