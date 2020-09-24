using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;
            for (int i = 0; i < number; i++)
            {
                int sum = int.Parse(Console.ReadLine());
                
                if(sum % 2 == 0)
                {
                    even += sum;
                }
                else
                {
                    odd += sum;
                }
                

            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else 
            {
                int difference = (Math.Abs(even - odd));
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {odd}");
            }


        }
    }
}
