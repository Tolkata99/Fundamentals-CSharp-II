using System;
using System.Diagnostics.CodeAnalysis;

namespace numberIsN
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            int Sum = 0;

            for (int i = 0; i < word.Length;i++)
            {
                char letter = word[i];

                if (letter == 'a')
                {
                    Sum += 1;
                }
                if (letter == 'e')
                {
                    Sum += 2;
                }
                if (letter == 'i')
                {
                    Sum += 3;
                }
                if (letter == 'o')
                {
                    Sum += 4;
                }
                if (letter == 'u')
                {
                    Sum += 5;
                }

            }
            Console.WriteLine(Sum);





        }
    }
}
