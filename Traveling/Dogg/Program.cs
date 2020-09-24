using System;

namespace Dogg
{
    class Program
    {
        static void Main(string[] args)
        {
            //            CЗакупеното количество храна за кученцето в килограми – цяло число в интервала[1 …100]
            //На всеки следващ ред до получаване на команда Adopted ще получавате колко грама изяжда кученцето на всяко хранене -цяло число в интервала[10 …1000]

            int FoodDogKG = int.Parse(Console.ReadLine());
            double FoodDogGr = FoodDogKG * 1000;
            //колко грама изяйда на ден.
            double daysEat = 0;
            while (true)
            {
                string Comand = Console.ReadLine();
                if(Comand == "Adopted")
                {
                    break;
                }

                int FoodDogDaysByGR = int.Parse(Comand);
                daysEat += FoodDogDaysByGR;
            }
            FoodDogGr -= daysEat;
            if (FoodDogGr > 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(FoodDogGr)} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(FoodDogGr)} grams more.");
            }

        }
    }
}
