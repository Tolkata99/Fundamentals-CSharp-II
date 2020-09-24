using System;

namespace maxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for(int i = 0; i < number; i++)
            {
                int sum = int.Parse(Console.ReadLine());

                if (sum > maxNumber)
                {
                    maxNumber = sum;

                }
                if (sum < minNumber)
                {
                    minNumber = sum;

                }
                
            }
            Console.WriteLine($"Max number: { maxNumber}");

            Console.WriteLine($"Min number: { minNumber}");
        }
    }
}
