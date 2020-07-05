namespace SumNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < countNumbers; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
