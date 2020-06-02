using System;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming args.
            for(int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg:{0}",i);

            // Helper method within the program class.
            ShowEnvironmentDetails();
            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();

            // Return an arbitrary error code.
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach(string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive:{0}",drive);

            Console.WriteLine("OS: {0}",Environment.OSVersion);
            Console.WriteLine("Number of Processors:{0}",Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}",Environment.Version);
            Console.Beep();
        }
    }
}
