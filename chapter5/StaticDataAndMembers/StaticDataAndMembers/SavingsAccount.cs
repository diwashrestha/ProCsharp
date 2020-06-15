using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;
        // A static point of data.
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
