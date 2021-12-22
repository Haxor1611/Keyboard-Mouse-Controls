using System;
using System.Threading;
using Controls;

namespace MouseExample
{
    internal class Program
    {
        public static readonly int[,] AssaultRifle = { { -69, 100 }, { 10, 92 }, { -110, 83 }, { -85, 75 }, { 0, 67 }, { 33, 57 }, { 58, 48 }, { 76, 39 }, { 84, 29 }, { 85, 19 }, { 76, 20 }, { 60, 37 }, { 34, 50 }, { 2, 59 }, { -30, 65 }, { -55, 67 }, { -74, 64 }, { -86, 59 }, { -92, 49 }, { -91, 34 }, { -84, 17 }, { -70, 10 }, { -49, 28 }, { -22, 42 }, { 24, 51 }, { 72, 56 }, { 97, 57 }, { 98, 51 }, { 77, 43 } };
        static void Main(string[] args)
        {
            MouseHandler mouseHandler = new MouseHandler();
            for(int i = 0; i < AssaultRifle.Length; i++)
            {
                mouseHandler.RelativeMove(AssaultRifle[i, 0], AssaultRifle[i,1]);
                Thread.Sleep(100);
            }

        }
    }
}
