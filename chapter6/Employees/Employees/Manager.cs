﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
        :base(fullName, age, empID, currPay, ssn)
        {
            // Assign incoming parameters using the 
            // inherited proprieties of the parent class.

            ID = empID;
            Age = age;
            Name = fullName;
            Pay = currPay;

            StockOptions = numbOfOpts;
        }
    }
}
