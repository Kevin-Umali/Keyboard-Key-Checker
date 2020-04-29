using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Keyboard_Tester.Classes
{
    internal class PressedKeys
    {
        public static string KeysCode(object sender, KeyEventArgs e, System.Collections.Generic.List<Tuple<Keys, string>> keylist)
        {
            string x = string.Empty;

            Tuple<Keys, string> FindKeys = keylist.FirstOrDefault(item => item.Item1.Equals(e.KeyCode));

            if (FindKeys != null)
            {
                if (e.KeyCode == FindKeys.Item1)
                {
                    x = FindKeys.Item2;
                }
            }

            return x;
        }

        public static Color GetReadableForeColor(Color c)
        {
            Color clr;

            clr = (((c.R + c.B + c.G) / 3) > 128) ? Color.Black : Color.White;

            return clr;
        }

        public static (bool, bool, bool) GetKeyLockState()
        {
            bool isNumLock = System.Windows.Input.Keyboard.IsKeyToggled(System.Windows.Input.Key.NumLock);
            bool isCapsLock = System.Windows.Input.Keyboard.IsKeyToggled(System.Windows.Input.Key.CapsLock);
            bool isScrollLock = System.Windows.Input.Keyboard.IsKeyToggled(System.Windows.Input.Key.Scroll);

            return (isNumLock, isCapsLock, isScrollLock);
        }
    }
}
