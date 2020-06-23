using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 20, 456, 30_000);
            emp.Age++;
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // Reset and then get the Name property.
            emp.Name = "Marc";
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);
            Console.ReadLine();
        }
    }
}
