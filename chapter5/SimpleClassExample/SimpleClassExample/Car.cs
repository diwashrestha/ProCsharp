using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car
        public string petName;
        public int currSpeed;

        // The Functionality of the car.
        // Using the expression-bodied member syntax introduced in c# 6
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
