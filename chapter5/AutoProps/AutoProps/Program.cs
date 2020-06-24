using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That's odd...", c.PetName);
            c.DisplayStats();

            Garage g = new Garage();
            g.MyAuto = c;
            // OK, prints default value of zero.
            Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);

            // Runtime error! Backing field is currently null!
            Console.WriteLine(g.MyAuto.PetName);
            Console.ReadLine();
        }
    }
}
