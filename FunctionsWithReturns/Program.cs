using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "Chicken wings", "burger", "french fries", "salad", "pizza" };
            string[] drinks = { "coca cola", "fanta", "pepsi", "water" };

            //DisplayRandomFromArray(foods);
            //DisplayRandomFromArray(drinks);
            string randomSnack = PickRandomFromArray(foods);
            string randomDrink = PickRandomFromArray(drinks);



            Console.WriteLine($"computer picked {randomSnack} and {randomDrink} for your movie night");
        }

        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];

            return randomElement;
        }

        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"computer has chosen {someArray[randomIndex]}");

        }



    }
}
