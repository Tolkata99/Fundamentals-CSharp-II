using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string vidCvete = Console.ReadLine();
            int broiCvetq = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            //Цена на брой в лева 5   3.80    2.80    3   2.50
            double result = 0.0;
            if (vidCvete == "Roses")
            {
                result = broiCvetq * 5;
                if(broiCvetq > 80)
                {
                    result *= 0.90;
                }
                
            }
            else if (vidCvete == "Dahlias")
            {
                result = broiCvetq * 3.80;
                if(broiCvetq > 90)
                {
                    result *= 0.85;
                }
            }
            else if (vidCvete == "Tulips")
            {
                result = broiCvetq * 2.80;
                if (broiCvetq > 80)
                    result *= 0.85;
            }
            else if (vidCvete == "Narcissus")
            {
                result = broiCvetq * 3;
                if(broiCvetq < 120)
                {
                    result *= 1.15;
                }
            }
            else if (vidCvete == "Gladiolus")
            {

                result = broiCvetq * 2.50;
                if(broiCvetq <  80)
                {
                    result *= 1.20;
                }

               
            }
            double moneyLeft = budget - result;
            string output = string.Empty;

            if (budget >= result)
            {

                output = $"Hey, you have a great garden with {broiCvetq} {vidCvete} and {moneyLeft:f2} leva left.";
                
            }
            else 
            {
                output = $"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.";
            }

            Console.WriteLine(output);



        }   
    }
}
