using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("**** Fun with Class Types ****\n");

           // Invoking the default constructor.
           Car chuck = new Car();

           // Prints "Chuck is going 10 MPH."
           chuck.PrintState();

            // Make a car called Mary going 0 MPH.
            Car mary = new Car("Mary");
            mary.PrintState();

            // Make a car called Daisy going 75 MPH.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            Console.WriteLine();


           // Allocate and configure a Car object.
           Car myCar = new Car();
           myCar.petName = "Henry";
           myCar.currSpeed = 10;

           // Speed up the car a few times and print out the 
           // new state
           for (int i = 0; i <= 10; i++)
           {
               myCar.SpeedUp(5);
               myCar.PrintState();
           }

           // MotorCycle
           Motorcycle mc = new Motorcycle();
           mc.PopAwheely();

           // Make a Motor

           Console.ReadLine();
        }
    }
}
