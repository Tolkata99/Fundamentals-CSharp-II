using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете 2*n-на брой цели числа, подадени от п
            //отребителя, и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите
            //n числа (дясна сума). При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
            //Разликата се изчислява като положително число (по абсолютна стойност). 
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int dqsnasum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
                
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                dqsnasum += num;
            }
            if(dqsnasum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {dqsnasum}");
            }
            else
            {
                int con = dqsnasum - leftSum;
                Console.WriteLine($"No, diff = { Math.Abs(con)}");
            }
        }
    }
}
