using System;
using System.Data.SqlTypes;

namespace paswordd
{
    class Program
    {
        static void Main(string[] args)
        {

            string studentName = Console.ReadLine();
            int klas = 1;

            double sredenuspeh = 0 ;

            int skusannaizpit = 0;

            while (klas <= 12)
            {
                double ocenki = double.Parse(Console.ReadLine());
               
                if(ocenki >= 4)
                {
                    sredenuspeh += ocenki;
                    klas++;
                }
                else
                {
                    skusannaizpit++;
                    if(skusannaizpit > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {klas} grade");
                        break;
                    }
                }
                if(klas == 13)
                {
                    double result = sredenuspeh / 12;
                    Console.WriteLine($"{studentName} graduated. Average grade: {result:f2}");
                }
                

                

            }

        }
    }
}
