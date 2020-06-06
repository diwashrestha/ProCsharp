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
            IfElseExample();
            ExecuteIfElseUsingConditionalOperator();
            SwitchOnStringExample();
            SwitchOnEnumExample();
            SwitchWithGoto();
            ExecutePatternMatchingSwitch();
            Console.WriteLine();
        }

        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.Write("Please choose an option: ");
            string userChoice = Console.ReadLine();
            object choice;

            // This is a standard constant pattern switch statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            // This is new the pattern mathing switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}.",i);
                    break;
                case string s:
                    Console.WriteLine("Your Choice is a string {0}",s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choice is a decimal {0}.",d);
                    break;
                default:
                    Console.WriteLine("Your Choice is something else");
                    break;
            }
            Console.WriteLine();
        }

        private static void SwitchWithGoto()
        {
            var foo = 5;
            switch (foo)
            {
                case 1:
                    Console.WriteLine("1");
                    goto case 2;
                case 2:
                    Console.WriteLine("2");
                    goto default;
                default:
                    Console.WriteLine("default");
                    break;

            }
        }

        private static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
            }
            Console.WriteLine();
        }

        private static void SwitchOnStringExample()
        {
            Console.WriteLine("C# or VB");
            Console.WriteLine("Please pick your language preference");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;

            }
            Console.WriteLine();
        }

        private static void ExecuteIfElseUsingConditionalOperator()
        {
            string stringData = "My textual data";
            Console.WriteLine(stringData.Length > 0
                ? "string is greater than 0 characters"
                : "string is not greater than 0 characters");
            Console.WriteLine();
        }

        private static void IfElseExample()
        {
            string stringData = "My textual data";
            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                Console.WriteLine("string is not greater than 0 characters");
            }
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
