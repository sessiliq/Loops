namespace OddEvenSum
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += int.Parse(Console.ReadLine());
                }
                else
                {
                    sumOdd += int.Parse(Console.ReadLine());
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }

        }
    }
}
