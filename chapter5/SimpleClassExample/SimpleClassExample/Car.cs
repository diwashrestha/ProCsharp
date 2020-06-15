﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car
        public string petName;
        public int currSpeed;


        // A custom default constructor
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Here, currSpeed will receive the 
        // default value of an int (zero).
        public Car(string pn)
        {
            petName = pn;
        }

        // Let caller set the full state of the Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        // The Functionality of the car.
        // Using the expression-bodied member syntax introduced in c# 6
        public void PrintState()
            => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
