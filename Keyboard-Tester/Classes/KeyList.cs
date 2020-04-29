using System;
using System.Collections.Generic;

namespace Keyboard_Tester.Classes
{
    internal class KeyList
    {
        public static List<Tuple<System.Windows.Forms.Keys, string>> GetKeys()
        {
            List<Tuple<System.Windows.Forms.Keys, string>> KeyList = new List<Tuple<System.Windows.Forms.Keys, string>>();

            #region TOP LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Escape, "ESC"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F1, "F1"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F2, "F2"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F3, "F3"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F4, "F4"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F5, "F5"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F6, "F6"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F7, "F7"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F8, "F8"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F9, "F9"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F10, "F10"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F11, "F11"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F12, "F12"));
            #endregion

            #region NUMBER LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Oemtilde, "S9"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D1, "D1"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D2, "D2"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D3, "D3"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D4, "D4"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D5, "D5"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D6, "D6"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D7, "D7"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D8, "D8"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D9, "D9"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D0, "D0"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemMinus, "S10"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Oemplus, "S11"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Back, "BACKSPACE"));
            #endregion

            #region FIRST LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Q, "Q"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.W, "W"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.E, "E"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.R, "R"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.T, "T"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Y, "Y"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.U, "U"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.I, "I"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.O, "O"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.P, "P"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemOpenBrackets, "S1"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemCloseBrackets, "S2"));
            #endregion

            #region SECOND LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.A, "A"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.S, "S"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.D, "D"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.F, "F"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.G, "G"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.H, "H"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.J, "J"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.K, "K"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.L, "L"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemSemicolon, "S3"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemQuotes, "S4"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Oem5, "S5"));
            #endregion

            #region THIRD LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Z, "Z"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.X, "X"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.C, "C"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.V, "V"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.B, "B"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.N, "N"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.M, "M"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Oemcomma, "S6"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemPeriod, "S7"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.OemQuestion, "S8"));
            #endregion

            #region IDK LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Tab, "TAB"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.CapsLock, "CAPSLOCK"));
            //KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.ShiftKey, "LSHIFT"));
            //KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.ShiftKey, "RSHIFT"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Enter, "ENTER"));
            #endregion

            #region BOTTOM LINE
            //KeyList.Add(Tuple.Create(System.Windows.Forms.Keys., "LCTRL"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.LWin, "WIN"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Alt, "LALT"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Space, "SPACE"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Apps, "MENU"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.RWin, "RWIN"));
            //KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.RControlKey, "RCTRL"));
            #endregion

            #region ARROW LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Up, "UP"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Down, "DOWN"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Left, "LEFT"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Right, "RIGHT"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Snapshot, "PRINTSCREEN"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Scroll, "SCROLLLOCK"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Pause, "PAUSEBREAK"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Insert, "INSERT"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Home, "HOME"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.PageUp, "PAGEUP"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.PageDown, "PAGEDOWN"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Delete, "DELETE"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.End, "END"));
            #endregion

            #region NUMBERPAD LINE
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumLock, "NUMLOCK"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad1, "N1"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad2, "N2"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad3, "N3"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad4, "N4"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad5, "N5"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad6, "N6"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad7, "N7"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad8, "N8"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad9, "N9"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.NumPad0, "N0"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Divide, "DIVIDE"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Multiply, "MULTIPLY"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Subtract, "MINUS"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Add, "ADD"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Enter, "NENTER"));
            KeyList.Add(Tuple.Create(System.Windows.Forms.Keys.Decimal, "DECIMAL"));
            #endregion
            return KeyList;
        }
    }
}
