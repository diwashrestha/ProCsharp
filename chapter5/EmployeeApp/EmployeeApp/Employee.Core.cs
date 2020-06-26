using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    partial class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;




        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

    }
}
