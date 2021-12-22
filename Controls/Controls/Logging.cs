using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace Controls
{
    public class Logging{

        public string logKeyPresses(int length){
            StringBuilder sb = new StringBuilder();
            KeyboardHandler handler = new KeyboardHandler();
            int count = 0;
            while(count < length){
                var keyPressed = handler.getKeyPressed();//get the key pressed
                if(keyPressed != ControlKeys.VirtualKeycodes.None){//if the key is pressed and isnt nothing
                    sb.Append(keyPressed);
                    count++;
                } else{
                    continue;
                }
                Thread.Sleep(250);
            }
            return sb.ToString();
        }
    }
}
