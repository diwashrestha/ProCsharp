using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        // Overriding System.Object.ToString()
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age:{Age}]";

        // Overriding System.Object.Equals()
        public override bool Equals(object obj) => obj?.ToString() == ToString();

        // Return a hash code based on the person's ToString() value.
        public override int GetHashCode() => ToString().GetHashCode();
    }
}
