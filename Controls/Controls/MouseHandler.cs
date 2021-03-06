using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Controls
{
    public class MouseHandler{
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern ushort GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);  
        public void SendMouseClick(ControlKeys.MouseButtons button)
        {
            mouse_event((uint)button, 0, 0, 0, 0);//send the mouse click
        }
        public bool isMouseButtonPressed(ControlKeys.MouseButtons button)
        {
            return 0 != (GetAsyncKeyState((byte)button) & 0x8000);//0x8000 is the bitmask for the key being pressed
        }
        public void RelativeMove(int relx, int rely)
		{
			mouse_event(0x0001, relx, rely, 0, 0);//move the mouse
		}

        public MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }//if the mouse is not on the screen, return a point at 0,0
            return currentMousePoint;
        }
        public void setCursorPosition(int x, int y)
        {
            SetCursorPos(x,y);//set the cursor position
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
            
        }
    }
    

}