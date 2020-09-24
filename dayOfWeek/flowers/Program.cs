using System;
using System.Data;

namespace flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            double totalPrise = 0;
            if (flowerType == "Roses")
            {
                totalPrise *= 5;
                if(numberFlowers > 80)
                {
                    totalPrise *= 0.9;
                }
            }
            if (flowerType == "Dahlias")
            {
                totalPrise *= 3.80;
                if(numberFlowers > 90)
                {
                    totalPrise *= 0.85;
                }

            }
            if (flowerType == "Tulips")
            {
                totalPrise *= 2.80;
                if(numberFlowers > 80)
                {
                    totalPrise *= 0.85;
                }
                     
            }
            if (flowerType == "Narcissus")

            {
                totalPrise *= 3;
                if(numberFlowers < 120)
                {
                    totalPrise *= 1.15;
                }
            }
            if (flowerType == "Gladiolus")
            {
                totalPrise  *= 2.50;
                if(numberFlowers < 80)
                {
                    totalPrise *= 1.2;
                }


            }
            

            double moneyLeft =  budget - totalPrise;
            string output = string.Empty;
            if (budget >= totalPrise)
            {
                output = $"Hey, you have a great garden with {numberFlowers} {flowerType} and {moneyLeft} leva left.";
            }
            else if (totalPrise <= budget)
            {
                output = $"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.";

            }
            Console.WriteLine(output);

        }
    }
}
