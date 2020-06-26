using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson()
        {
        }

        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empID,
            float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
    }
}
