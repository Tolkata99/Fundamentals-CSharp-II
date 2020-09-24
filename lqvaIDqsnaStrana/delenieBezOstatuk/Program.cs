using System;

namespace delenieBezOstatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
           

            for (int i = 1; i <= number; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());

                if(numberOne % 2 == 0)
                {
                    p1++;
                }
                if (numberOne % 3 == 0)
                {
                    p2++;
                }
                if (numberOne % 4 == 0)
                {
                    p3++;
                }
                

                

            }
            double result = p1 / number * 100;
            double result1 = p2 / number * 100;
            double result2 = p3 / number * 100;

            Console.WriteLine($"{result:f2}%");
            Console.WriteLine($"{result1:f2}%");
            Console.WriteLine($"{result2:f2}%");
        }
    }
}
