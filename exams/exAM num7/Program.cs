using System;

namespace exAM_num7
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());

            double max = double.MinValue;
            double max1 = double.MinValue;
            double sumSugar = 0;
            double sumFlour = 0;


            for (int i = 1; i <= easterBread; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                sumSugar += sugar;
                int flour = int.Parse(Console.ReadLine());
                sumFlour += flour;

                if(sugar > max)
                {
                    max = sugar;
                }

                if (flour > max1)
                {
                    max1 = flour;
                }

            }
            sumSugar /= 950;
            sumFlour /= 750;
            



            Console.WriteLine($"Sugar:{Math.Ceiling(sumFlour)}");
            Console.WriteLine($"Flour:{Math.Ceiling(sumSugar)}");

            Console.WriteLine($"Max used flour is {max1}" +
                $" grams, max used sugar is {max} grams.");

        }
        
    }
}
