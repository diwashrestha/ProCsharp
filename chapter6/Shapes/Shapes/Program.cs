using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            // Make an array of Shape- Compatible objects.
            Shape[] myShapes =
            {
                new Hexagon(), new Circle(), new Hexagon("Mick"),
                new Circle("Diwash"), new Hexagon("Lynda")
            };

            // Loop over each item and interact with the
            // Polymorphic interface.
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            Console.ReadLine();

            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
            Circle cir = new Circle("Cindy");
            cir.Draw();

            // This calls the Draw() method of the ThreeDCircle.
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            // This calls the Draw() method of the parent!
            ((Circle)o).Draw();
            Console.ReadLine();
        }
    }
}
