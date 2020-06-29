using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            //Person p1 = new Person();

            // Use inherited members of System.Object.
            //Console.WriteLine("To String: {0}", p1.ToString());
            //Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            //Console.WriteLine("Type: {0}", p1.GetType());

            // Make some other references to p1.
           // Person p2 = p1;
           // object o = p2;

            // Are the references pointing to the same object in memory?
            //if (o.Equals(p1) && p2.Equals(o))
            //{
             //   Console.WriteLine("Same instance!");
            //}

            Person p3 = new Person("Homer","Simpson",50);
            Person p4 = new Person("Homer", "Simpson", 50);

            // Get stringified version of objects.
            Console.WriteLine("P3.ToString() = {0}", p3.ToString());
            Console.WriteLine("P4.ToString() = {0}", p4.ToString());

            // Test overridden Equals().
            Console.WriteLine("p3 = p4? : {0}", p3.Equals(p4));

            // Test hash codes.
            Console.WriteLine("Same hash codes?: {0}", p3.GetHashCode() == p4.GetHashCode());

            // Change age of p3 and test again.
            p3.Age = 45;
            Console.WriteLine("P3.ToString() = {0}", p3.ToString());
            Console.WriteLine("P4.ToString() = {0}", p4.ToString());
            Console.WriteLine("P3 = p4?: {0}",p3.Equals(p4));
            Console.WriteLine("Same hash codes?: {0}", p3.GetHashCode() == p4.GetHashCode());
            
            Console.ReadLine();
        }
    }
}
