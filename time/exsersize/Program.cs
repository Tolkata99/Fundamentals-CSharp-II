using System;
using System.Runtime.InteropServices;

namespace exsersize
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = n; i <= b; i++)
            {
                int number = i;
                int oddSum = 0;
                int evenSum = 0;

                bool istrue = true;
                while (number > 0)                
                {
                    int lastDigit = number % 10;

                    if (istrue)
                    {
                        evenSum += lastDigit;
                        istrue = false;
                    }
                    else
                    {
                        oddSum += lastDigit;
                        istrue = true;
                    }
                    number /= 10;

                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }



        }
    }
}
