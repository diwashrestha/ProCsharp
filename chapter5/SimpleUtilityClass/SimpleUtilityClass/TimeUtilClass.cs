using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.VisualBasic.DateAndTime;

namespace SimpleUtilityClass
{
    static class TimeUtilClass
    {
        public static void PrintTime()
            => Console.WriteLine(Now.ToShortTimeString());

        public static void PrintDate()
            => Console.WriteLine(Today.ToShortDateString());
    }
}
