using System;
using System.Linq;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultiDimensionalArray();
            JaggedMultidimensionalArray();
            Console.ReadLine();
        }

        private static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];


            // Print each row (remember, each element is defaulted to zero!).
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(myJagArray[2].Length);
        }

        private static void RectMultiDimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3,4];

            // Populate (3 * 4) array.
            for(int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An Array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        private static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        private static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[]{"one", "two", "three"};
            Console.WriteLine("string Array has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = {false, false, true};
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] {20, 22, 23, 0};
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        private static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach(int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();

        }
    }
}
