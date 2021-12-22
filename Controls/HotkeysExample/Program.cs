using System;
using Controls;

namespace HotkeysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotkeySetup hotkeySetup = new HotkeySetup();
            KeyboardHandler keyboardHandler = new KeyboardHandler();
            hotkeySetup.hotkeyThread(ControlKeys.VirtualKeycodes.F1, keyboardHandler, () => f1pressed());
            hotkeySetup.hotkeyThread(ControlKeys.VirtualKeycodes.F2, keyboardHandler, () => f2pressed());
        }
        static void f1pressed()
        {
            Console.WriteLine("F1 Pressed");
        }
        static void f2pressed()
        {
            Console.WriteLine("F2 Pressed");
        }
    }
}
