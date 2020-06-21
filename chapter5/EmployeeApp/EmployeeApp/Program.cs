using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            Employee emp2 = new Employee();
            emp2.SetName("Xena the warrior princess");

            // Use the get/set methods to interact with the object's name.
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
            Console.ReadLine();
        }
    }
}
