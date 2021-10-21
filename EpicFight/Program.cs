using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = RandomHero();
            string villain = RandomVillain();
            Console.WriteLine($"fight will be between {hero} and {villain}");
        }

        private static string RandomHero()
        {
            string[] heroes = {"Obama", "Mussoliini", "JFK", "Lenin", "Kanye", "Ubisoft"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            return heroes[randomIndex];
        }

        private static string RandomVillain()
        {
            string[] villains = {"George floyd", "Jooo_baiden", "Barrett M82", "turtle", };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            return villains[randomIndex];
        }
    }
}
