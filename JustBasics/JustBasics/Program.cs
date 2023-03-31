using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBasics
{
    class Program
    {
        static int Main()
        {
            // Display a message and wait for Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            ShowEnvironmentDetails();
            Console.ReadLine();
    
            // Return an arbitrary error code.
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}",
            Environment.Version);
        }
    }
}
