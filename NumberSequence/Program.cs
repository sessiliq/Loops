namespace NumberSequence
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < countNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers < min)
                {
                    min = numbers;
                }
                
                if (numbers > max)
                {
                    max = numbers;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
