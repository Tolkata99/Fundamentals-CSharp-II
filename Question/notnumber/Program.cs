using System;

namespace notnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double counterP1 = 0;
            double counterP2 = 0;
            double counterP3 = 0;
            for (int i = 1; i <= number; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                if(n1 % 2 == 0)
                {
                    counterP1++;
                }
                if(n1 % 3 == 0)
                {
                    counterP2++;
                }
                if(n1 % 4 == 0)
                {
                    counterP3++;
                }


               

            }
            double resultP1 = (counterP1 / number) * 100.0;
            double resultP2 = (counterP2 / number) * 100.0;
            double resultP3 = (counterP3 / number) * 100.0;
                                          

            Console.WriteLine($"{resultP1:f2}%");
            Console.WriteLine($"{resultP2:f2}%");
            Console.WriteLine($"{resultP3:f2}%");

        }
    }
}
