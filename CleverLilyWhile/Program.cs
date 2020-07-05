namespace CleverLilyWhile
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            int priceToys = int.Parse(Console.ReadLine());

            int toys = 0;
            int moneyForBDay = 0;
            int money = 0;

            int i = 0;
            while (true)
            {
                if (i >= age)
                {
                    break;
                }

                if (i % 2 != 0)
                {
                    money += (moneyForBDay += 10) - 1;
                }
                else
                {
                    toys += 1;
                }

                i++;
            }

            int moneyForToys = toys * priceToys;
            int allMoney = money + moneyForToys;

            if (priceWash <= allMoney)
            {
                Console.WriteLine($"Yes! {allMoney - priceWash:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWash - allMoney:F2}");
            }
        }
    }
}
