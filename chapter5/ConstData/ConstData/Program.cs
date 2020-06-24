using System;

namespace ConstData
{
    class MyMathClass
    {
        public static readonly double PI = 3.14;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);

            Console.ReadLine();
        }
    }
}
