using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;
            double p4 = 0.00;
            double p5 = 0.00;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                if (number >= 200 && number <= 399)
                {
                    p2++;
                }
                if (number >= 400 && number <= 599)
                {
                    p3++;
                }
                if(number >= 600 && number <= 799)
                {
                    p4++;
                }
                if(number >= 800)
                {
                    p5++;
                }                
            }
            double p1Result = p1 / n * 100;
            double p2Result = p2 / n * 100;
            double p3Result = p3 / n * 100;
            double p4Result = p4 / n * 100;
            double p5Result = p5 / n * 100;

            Console.WriteLine($"{p1Result:f2}%");
            Console.WriteLine($"{p2Result:f2}%");
            Console.WriteLine($"{p3Result:f2}%");
            Console.WriteLine($"{p4Result:f2}%");
            Console.WriteLine($"{p5Result:f2}%");

        }
    }
}
