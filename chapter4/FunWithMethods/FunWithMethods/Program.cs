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
            // C# 7 allows for out parameters to be declared in th metho calll
            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);

            int i;
            string str;
            bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}",str);
            Console.WriteLine("Boolean is:{0}", b);
            Console.ReadLine();

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
