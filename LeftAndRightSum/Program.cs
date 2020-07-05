namespace LeftAndRightSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                sumLeft += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < countNumbers; i++)
            {
                sumRight += int.Parse(Console.ReadLine());
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}" );
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumLeft - sumRight)}");
            }
        }
    }
}
