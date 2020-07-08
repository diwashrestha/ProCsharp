using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stage 1
            //Console.WriteLine("Starting to make a coffee");
            //Console.WriteLine("Grinding coffee beans");
            //Console.WriteLine("Boiling water");
            //Console.WriteLine("Mixing boiled water with crushed coffee beans");
            //Console.WriteLine("Pouring coffee into the cup");
            //Console.WriteLine("Pouring some milk into the cup");
            //Console.WriteLine("Coffee is ready!");

            Console.WriteLine("Write how many cups of coffee you will need: ");
            int coffeeCup = Convert.ToInt32(Console.ReadLine());

            coffeeItemsCalculator(coffeeCup);
        }

        public static void coffeeItemsCalculator(int coffeeCup)
        {
            int waterAmount = 200 * coffeeCup;
            int milkAmount = 50 * coffeeCup;
            int coffeeBean = 15 * coffeeCup;

            Console.WriteLine("For {0} cups of coffee you will need:", coffeeCup);
            Console.WriteLine("{0} ml of water", waterAmount);
            Console.WriteLine("{0} ml of milk", milkAmount);
            Console.WriteLine("{0} g of coffee beans", coffeeBean);


        }
    }
}
