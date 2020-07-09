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

            //Console.WriteLine("Write how many cups of coffee you will need: ");
            //int coffeeCup = Convert.ToInt32(Console.ReadLine());

            // Amount of required items to make coffee
            int waterAmount = 400;
            int milkAmount = 540;
            int coffeeBeans = 120;
            int disposableCups = 9;
            int money = 550;

            //CoffeeCupCalculator();
            CoffeeActions(ref waterAmount, ref milkAmount, ref coffeeBeans, ref disposableCups, ref money);
        }

        public static void CoffeeItemsCalculator(int coffeeCup)
        {
            int waterAmount = 200 * coffeeCup;
            int milkAmount = 50 * coffeeCup;
            int coffeeBean = 15 * coffeeCup;

            Console.WriteLine("For {0} cups of coffee you will need:", coffeeCup);
            Console.WriteLine("{0} ml of water", waterAmount);
            Console.WriteLine("{0} ml of milk", milkAmount);
            Console.WriteLine("{0} g of coffee beans", coffeeBean);
        }

        public static void CoffeeCupCalculator()
        {
            Console.WriteLine("Write how many ml of water the coffee machine has:");
            int waterAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write how many ml of milk the coffee machine has:");
            int milkAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write how many grams of coffee beans the coffee machine has:");
            int coffeeBean = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write how many cups of coffee you will need:");
            int requiredCoffeeCups = Convert.ToInt32(Console.ReadLine());

            int possibleCoffeeCups = 0;
            while(waterAmount >= 200 && milkAmount >= 50 && coffeeBean >= 15)
            {
                    possibleCoffeeCups++;
                    waterAmount = waterAmount - 200;
                    milkAmount = milkAmount - 50;
                    coffeeBean = coffeeBean - 15;
            }

            if(requiredCoffeeCups < possibleCoffeeCups)
            {
                Console.WriteLine("Yes, I can make that amount of coffee (and even {0} more than that).",
                    Math.Abs(possibleCoffeeCups-requiredCoffeeCups));
            }
            else if(requiredCoffeeCups > possibleCoffeeCups)
            {
                Console.WriteLine("No, I can make only {0} cup(s) of coffee.", possibleCoffeeCups);
            }
            else if(requiredCoffeeCups == possibleCoffeeCups)
            {
                Console.WriteLine("Yes, I can make that amount of coffee.");
            }
        }

        public static void CoffeeActions( ref int waterAmount, ref int milkAmount,
            ref int coffeeBeans, ref int  disposableCups, ref int money)
        {
            CoffeeMachineState(ref waterAmount, ref milkAmount,ref coffeeBeans,ref disposableCups,ref money);
            string coffeeActionSwitch;
            Console.WriteLine("Write action (buy, fill, take:)");
            coffeeActionSwitch = Console.ReadLine();

            switch (coffeeActionSwitch)
            {
                case "buy":
                    Console.WriteLine("Case buy");
                    CoffeeMachineState(ref waterAmount, ref milkAmount,
                        ref coffeeBeans, ref disposableCups, ref money);
                    break;
                case "fill":
                    Console.WriteLine("Case fill.");
                    CoffeeMachineState(ref waterAmount, ref milkAmount,
                        ref coffeeBeans, ref disposableCups, ref money);
                    break;
                case "take":
                    Console.WriteLine("Case take");
                    CoffeeMachineState(ref waterAmount, ref milkAmount,
                        ref coffeeBeans, ref disposableCups, ref money);
                    break;

            }
        }

        public static void CoffeeMachineState(ref int waterAmount, ref int milkAmount, ref int coffeeBeans, ref int disposableCups, ref int money)
        {
            Console.WriteLine("The coffee machine has:");
            Console.WriteLine("{0} of water", waterAmount);
            Console.WriteLine("{0} of milk", milkAmount);
            Console.WriteLine("{0} of coffee beans", coffeeBeans);
            Console.WriteLine("{0} of disposable cups", disposableCups);
            Console.WriteLine("{0} of money", money);
        }
    }
}
