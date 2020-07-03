using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleException
{
    class Car
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        // Is the car still operational?
        private bool _carIsDead;

        // A car has-a radio.
        private Radio theMusicBox = new Radio();

        // Constructors.
        public Car() {}

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheated.
        public void Accelerate(int delta)
        {
            if (_carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    _carIsDead = true;
                    CurrentSpeed = 0;

                    // We need to call the HelpLink property, thus we need to
                    // create a local variable before throwing the Exception object.
                    Exception ex = new Exception($"{PetName} has overheated!");
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed ={0}", CurrentSpeed);
                }
            }
        }
    }
}
