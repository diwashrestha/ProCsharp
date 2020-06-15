using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name)
        {
            name = this.name;
        }
        public void PopAwheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaeeewww!");
            }
        }

        // Put back the default constructor , which will
        // set all data members to default values.
        public Motorcycle(){ }

        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

    }
}
