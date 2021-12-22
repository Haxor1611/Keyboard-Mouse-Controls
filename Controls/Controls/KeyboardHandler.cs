using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Controls
{
    public class KeyboardHandler
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("user32.dll")]
		private static extern ushort GetAsyncKeyState(int vKey);

      public void SendKey(ControlKeys.VirtualKeycodes key)
      {
        keybd_event((byte)key,0,0,0);
      }
      public bool isKeyPressed(ControlKeys.VirtualKeycodes key)
      {
        return 0 != (GetAsyncKeyState((byte)key) & 0x8000);
      }

    public ControlKeys.VirtualKeycodes getKeyPressed()
    {
      ControlKeys.VirtualKeycodes[] values = Enum.GetValues(typeof(ControlKeys.VirtualKeycodes)) as ControlKeys.VirtualKeycodes[];
      foreach(ControlKeys.VirtualKeycodes v in values){
        if(isKeyPressed(v)){
          return v;
        } 
      }
      return ControlKeys.VirtualKeycodes.None;
    }
    }

    
}
