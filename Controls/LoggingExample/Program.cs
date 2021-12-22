using System;
using System.IO;
using Controls;

namespace LoggingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logging logging = new Logging();
            string keyPresses = logging.logKeyPresses(10);//logs 10 key presses
            File.WriteAllText("log.txt", keyPresses);//puts it in a file
            Console.WriteLine("Done.");

        }
    }
}
