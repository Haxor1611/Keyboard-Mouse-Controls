using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace Controls
{
    public class HotkeySetup{

        public void setHotkey(ControlKeys.VirtualKeycodes key,  KeyboardHandler handler, Action method){
            while(true){//wait for key to be pressed
                if(handler.isKeyPressed(key)){//if the key is pressed
                    method();
                    Thread.Sleep(250); //wait for the key to be released
                } else{
                    Thread.Sleep(10);
                }
            }
 
        }
        public void hotkeyThread(ControlKeys.VirtualKeycodes key, KeyboardHandler handler, Action method){
            Thread thr = new Thread(() => setHotkey(key, handler, method));//create a new thread
            thr.Start();//start the thread
            //i am no good coder, this is the only way i could get the thread to work
            //i am not sure if this is the best way to do it, but it works
            
        }
        
    }
}