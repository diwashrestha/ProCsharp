using System;
using System.Net.Sockets;
using System.Linq;

namespace CSharpIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            LinqQueryOverInts();
            WhileLoopExample();
            DoWhileLoopExample();
            Console.WriteLine();
        }

        private static void DoWhileLoopExample()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes");
        }

        private static void WhileLoopExample()
        {
            string userIsDone = "";

            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]");
                userIsDone = Console.ReadLine();
            }
            Console.WriteLine();
        }

        private static void LinqQueryOverInts()
        {
            int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8};

            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");

            foreach (var i in subset)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }

        private static void ForEachLoopExample()
        {
            string[] carTypes = {"Ford", "BMW", "Yugo", "Honda"};
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = {10, 20, 30, 40};
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        private static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}", i);
            }
            Console.WriteLine();
        }
    }
}
