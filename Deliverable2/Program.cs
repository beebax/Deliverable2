using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, welcome to our restaurant! We are an all you can eat buffet. The price is $9.99 per person. We only charge extra for coffee, which is $2 per person.");
        Console.WriteLine();
        Console.WriteLine("How many are in your group? We can seat parties of six or fewer.");
        int NumberDiners = int.Parse(Console.ReadLine());

        if (NumberDiners > 6) {Console.WriteLine("Sorry, we can only seat parties of six or fewer. Have a nice day!"); }

        else {Console.WriteLine("Table for " + NumberDiners + ". Right this way!");
            Console.WriteLine();
            Console.WriteLine("Let's get you started with something to drink. We have water or coffee.");

            int NumberCoffees = 0;
            int NumberWaters = 0;

            for (int RunningDiners = 1; RunningDiners <= NumberDiners; RunningDiners++) {
                Console.WriteLine("Person " + RunningDiners + ", what can I get you to drink?");
                string NewPersonDrink = Console.ReadLine();
                if (NewPersonDrink == "water") {
                    Console.WriteLine("Okay, I'll get that water for you right away.");
                    Console.WriteLine();
                    NumberWaters++;}
                else if (NewPersonDrink == "coffee") {
                    Console.WriteLine("Okay, I'll get that coffee for you right away.");
                    Console.WriteLine();
                    NumberCoffees++;}
                else { Console.WriteLine("Sorry, we don't serve that here.");
                    Console.WriteLine();} }

            Console.WriteLine("All together, you ordered " + NumberCoffees + " coffees and " + NumberWaters + " waters. Feel free to grab your food, and I'll be right back with your drinks and check.");
            Console.WriteLine();

            double BuffetPricePP = 9.99;
            double CoffeePricePP = 2;
            double WaterPricePP = 0;
            double BillTotal = (BuffetPricePP * NumberDiners) + (CoffeePricePP * NumberCoffees) + (WaterPricePP * NumberWaters);

            Console.WriteLine("Your total today comes to $" + BillTotal + ". Thank you for your business!");

        }
    }
}