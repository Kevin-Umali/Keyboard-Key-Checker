using Keyboard_Tester.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Keyboard_Tester
{
    public partial class Keyboard : Form
    {
        List<Tuple<Keys, string>> KeyList = Classes.KeyList.GetKeys();
        public Keyboard()
        {
            if (Properties.Settings.Default.isTheme)
            {
                InitializeComponent();
            }
            else
            {
                InitializeComponent1();
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.isTheme)
            //    radioButton2.Checked = true;
            //else
            //    radioButton1.Checked = true;


            numericUpDown1.Value = (decimal)richTextBox1.Font.Size;
            CheckKeyLockState();
            foreach (Control ctrl in Controls)
            {
                ctrl.PreviewKeyDown += new PreviewKeyDownEventHandler(IsInput);
            }
        }

        public void IsInput(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right
                || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
            else
            {
                e.IsInputKey = false;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys key);
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.LShiftKey)))
                {
                    if (Properties.Settings.Default.isTheme)
                    {
                        LSHIFT.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        LSHIFT.BackColor = Color.FromArgb(250, 250, 250);
                    }

                    LSHIFT.ForeColor = PressedKeys.GetReadableForeColor(LSHIFT.BackColor);

                    InputText(LSHIFT.Tag.ToString());
                }
                else if (Convert.ToBoolean(GetAsyncKeyState(Keys.RShiftKey)))
                {
                    if (Properties.Settings.Default.isTheme)
                    {
                        RSHIFT.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        RSHIFT.BackColor = Color.FromArgb(250, 250, 250);
                    }

                    RSHIFT.ForeColor = PressedKeys.GetReadableForeColor(RSHIFT.BackColor);

                    InputText(RSHIFT.Tag.ToString());
                }
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.LControlKey)))
                {
                    if (Properties.Settings.Default.isTheme)
                    {
                        LCTRL.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        LCTRL.BackColor = Color.FromArgb(250, 250, 250);
                    }

                    LCTRL.ForeColor = PressedKeys.GetReadableForeColor(LCTRL.BackColor);

                    InputText(LCTRL.Tag.ToString());
                }
                else if (Convert.ToBoolean(GetAsyncKeyState(Keys.RControlKey)))
                {
                    if (Properties.Settings.Default.isTheme)
                    {
                        RCTRL.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        RCTRL.BackColor = Color.FromArgb(250, 250, 250);
                    }

                    RCTRL.ForeColor = PressedKeys.GetReadableForeColor(RCTRL.BackColor);

                    InputText(RCTRL.Tag.ToString()); ;
                }
            }

            foreach (Button x in Controls.OfType<Button>())
            {
                if (x.Name.Equals(PressedKeys.KeysCode(sender, e, KeyList)))
                {
                    if (Properties.Settings.Default.isTheme)
                    {
                        x.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        x.BackColor = Color.FromArgb(250, 250, 250);
                    }
                    //x.Enabled = true;
                    x.ForeColor = PressedKeys.GetReadableForeColor(x.BackColor);
                    InputText(x.Tag.ToString());
                    break;
                }
            }

            if ((Control.ModifierKeys & Keys.Alt) != 0)
            {
                if (Properties.Settings.Default.isTheme)
                {
                    LALT.BackColor = Color.FromArgb(10, 10, 10);
                }
                else
                {
                    LALT.BackColor = Color.FromArgb(250, 250, 250);
                }

                if (Properties.Settings.Default.isTheme)
                {
                    RALT.BackColor = Color.FromArgb(10, 10, 10);
                }
                else
                {
                    RALT.BackColor = Color.FromArgb(250, 250, 250);
                }

                RALT.ForeColor = PressedKeys.GetReadableForeColor(RALT.BackColor);
                LALT.ForeColor = PressedKeys.GetReadableForeColor(LALT.BackColor);
                InputText(LALT.Tag.ToString());
            }
            CheckKeyLockState();
            label1.Focus();
        }

        private string previous;

        private void InputText(string val)
        {
            if (previous == DateTime.Now.ToString("hh:mm"))
            {
                richTextBox1.Text += val;
            }
            else
            {
                richTextBox1.Text += string.Format(Environment.NewLine + " TIME {0}: {1}", DateTime.Now.ToString("MM/dd hh:mm"), val);
                previous = DateTime.Now.ToString("hh:mm");
            }

            richTextBox1.Invalidate();
            richTextBox1.Update();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Button x in Controls.OfType<Button>())
            {
                if (Properties.Settings.Default.isTheme)
                {
                    x.BackColor = Color.FromArgb(254, 254, 254);
                }
                else
                {
                    x.BackColor = Color.FromArgb(50, 50, 50);
                }

                x.ForeColor = PressedKeys.GetReadableForeColor(x.BackColor);
                //x.Enabled = false;
            }
        }

        private void CheckKeyLockState()
        {
            (bool, bool, bool) keystate = PressedKeys.GetKeyLockState();
            Console.WriteLine("NL: {0} CL: {1} SL: {2}", keystate.Item1, keystate.Item2, keystate.Item3);
            if (keystate.Item1)
            {
                p1.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                p1.BackColor = Color.FromArgb(200, 200, 200);
            }

            if (keystate.Item2)
            {
                p2.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                p2.BackColor = Color.FromArgb(200, 200, 200);
            }

            if (keystate.Item3)
            {
                p3.BackColor = Color.FromArgb(128, 128, 255);
            }
            else
            {
                p3.BackColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Poppins", (float)numericUpDown1.Value);
        }

        public const int WM_NCLBUTTONWDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONWDOWN, HT_CAPTION, 0);
            }
        }

        private void Keyboard_DoubleClick(object sender, EventArgs e)
        {
            if (Size.Height == 358)
            {
                Size = new Size(1214, 548);
            }
            else
            {
                Size = new Size(1214, 358);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isTheme = true;
            Properties.Settings.Default.Save();
            MessageBox.Show("Restart the application to apply theme change");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isTheme = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Restart the application to apply theme change");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
