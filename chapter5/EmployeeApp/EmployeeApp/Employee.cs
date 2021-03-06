﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
     partial class Employee
    {
        // Constructors.
        public Employee() {}

        public Employee(string name, int id, float pay)
        :this(name, 0, id, pay){}

        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

        // Properties as before
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                {
                    empName = value;
                }
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

    }
}
