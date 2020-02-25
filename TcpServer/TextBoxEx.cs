using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TcpServer
{
    internal class TextBoxEx : TextBox
    {
        public bool HexOnly { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (HexOnly)
            {
                var ch = e.KeyChar;
                if (!IsHexadecimal(ch.ToString())
                    && ch != '\b'
                    && ch != ' '
                    && ch != '-')
                    e.Handled = true;
                else if (ch >= 'a' && ch <= 'f')
                    e.KeyChar = char.ToUpper(ch);
            }

            base.OnKeyPress(e);
        }

        private bool IsHexadecimal(string strInput)
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