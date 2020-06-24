using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");

            // Make aPoint by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax.
            Point finalPoint = new Point {X = 30, Y = 30};
            finalPoint.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold){X = 90, Y = 20};
            goldPoint.DisplayStats();
            Console.ReadLine();
        }
    }
}
