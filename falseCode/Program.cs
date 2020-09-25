using System;

namespace falseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            int total = 0;
            int takova = 0;
            bool isSpecial = false;
            for (int ch = 1; ch <= currentNumber; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    total += ch % 10;
                    ch = ch / 10;
                }
                isSpecial = (total == 5) ||
                    (total == 7) ||
                    (total == 11);
                Console.WriteLine("{0} -> {1}", takova, isSpecial);
                total = 0;
                ch = takova;
            }

        }
    }
}
