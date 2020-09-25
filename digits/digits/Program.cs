using System;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string integer =Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < integer.Length; i++)
            {
                int curentNumber = (int)char.GetNumericValue(integer[i]);
                sum += curentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
