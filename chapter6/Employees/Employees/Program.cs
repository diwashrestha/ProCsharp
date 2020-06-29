using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "33-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            double cost = chucky.GetBenefitCost();
            Console.Write(cost);

            Console.WriteLine("\n");
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
        }

        static void CastingExamples()
        {
            // A manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
             object frank = new Manager("Frank Aszapp", 9, 3000, 40000, "111-11-1111", 5);
             // (ClassIWantToCastTo)referenceIHave
             GivePromotion((Manager)frank);


            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321",1);
            GivePromotion(moonUnit);

            // A PTSalsesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119",90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            // Increase pay...
            // Give new parking space in company garage...
            Console.WriteLine("{0} was promoted!", emp.Name);
            switch (emp)
            {
                case SalesPerson s:
                    Console.WriteLine("{0} made {1} sales(s)!", emp.Name, s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;
            }
            Console.WriteLine();
        }
    }
}
