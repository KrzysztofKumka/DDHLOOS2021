using System;

namespace C5
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamFactory fabrykaLodow = new IceCreamFactory();
            IceCreamSeller sprzedawca = new IceCreamSeller(ref fabrykaLodow);
            Random rand = new Random();

            for (int i = 1; i<=7; i++)
            {
                Console.WriteLine("Day " + i + " special\n");
                int randN = rand.Next(2, 4);
                for (int j = 0; j <= randN; j++)
                {
                    fabrykaLodow.SetProductionMode(i);
                    sprzedawca.SuggestDailySpecial();
                }
                Console.WriteLine("Number of orders on the " + i + "th day: " + randN + "\n");
            }
        }
    }
}
