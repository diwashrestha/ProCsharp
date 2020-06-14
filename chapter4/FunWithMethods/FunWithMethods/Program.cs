using System;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");

            // Pass two variables in by value.
            int x = 9, y = 10;
            // Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            // Console.WriteLine("Answer is: {0}", Add(x,y));
            // Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.ReadLine();

            // No need to assign initial value to local variables
            // used as output parameters provided the first time
            // you use them ia as output arguments.
            // C# 7 allows for out parameters to be declared in th method call
            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);

            int i;
            string str;
            bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}",str);
            Console.WriteLine("Boolean is:{0}", b);

            // Pass in a comma-delimited list of doubles...
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            // or pass an array of doubles.
            double[] data = {4.0, 3.2, 5.7};
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");


            Console.ReadLine();

        }

        private static void DisplayFancyMessage(ConsoleColor textColor)
        {
            throw new NotImplementedException();
        }

        private static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = default)
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            Console.WriteLine("Time of Error: {0}", timeStamp);
            Console.WriteLine();
        }

        private static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        private static int Add(int x, int y, out int ans)
        {
            // int ans = x + y;
            ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the original data
            x = 10000;
            y = 88888;
            return ans;
        }
    }
}
