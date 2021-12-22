using System;
using System.Threading;
using Controls;

namespace Test_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing testing = new Testing();

            Console.WriteLine(testing.test());
            Thread.Sleep(1000);
            
            
            
        }
    }
}
