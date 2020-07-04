using System;
using CustomException;

namespace CustomException
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
            CarIsDeadException ex =
                new CarIsDeadException($"{PetName}  has overheated!","You have a lead foot", DateTime.Now);
            ex.HelpLink = "http://www.CarsRUs.com";
            throw ex;
            if (_carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);

        }
    }
}
