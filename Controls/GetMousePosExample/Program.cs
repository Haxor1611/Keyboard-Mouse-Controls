using System;
using Controls;

namespace GetMousePosExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MouseHandler mouseHandler = new MouseHandler();
            while (true)
            {
                var point = mouseHandler.GetCursorPosition();
                Console.WriteLine(point.X + ", " + point.Y);
            }
        }
    }
}
