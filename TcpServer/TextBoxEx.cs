using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TcpServer
{
    internal class TextBoxEx : TextBox
    {
        public bool HexOnly { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (HexOnly)
            {
                if (IsHexadecimal(Strings.Chr(e.KeyValue).ToString()) == false && e.KeyCode != Keys.Back)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            base.OnKeyDown(e);
        }

        public bool IsHexadecimal(string strInput)
        {
            var myRegex = new Regex("^[a-fA-F0-9]+$");
            //boolean variable to hold the status
            bool isValid;
            if (string.IsNullOrEmpty(strInput))
            {
                isValid = false;
            }
            else
            {
                isValid = myRegex.IsMatch(strInput);
            }
            //return the results
            return isValid;
        }
    }
}