﻿using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person p1 = new Person();

            // Use inherited members of System.Object.
            Console.WriteLine("To String: {0}", p1.ToString());
            Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            // Make some other references to p1.
            Person p2 = p1;
            object o = p2;

            // Are the references pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!");
            }
            Console.WriteLine();
        }
    }
}
