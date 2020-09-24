using System;

namespace foodAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ⦁	Брой дни – цяло число в диапазона[1…30]
            //⦁	Общо количество храна – реално число в диапазона[0.00…10000.00]
            //След това за всеки ден се чете:
            //⦁	Количество изядена храна от кучето – цяло число в диапазона[10…500]
            //⦁	Количество изядена храна от котката – цяло

            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double eatDog = 0;
            double eatCat = 0;

            double eatDog3Days = 0;
            double eatCat3Days = 0;

            double Days3Total = 0;
            for (int i = 1; i <= days ; i++)
            {
                double quantityEatenFoodDog = double.Parse(Console.ReadLine());
                eatDog += quantityEatenFoodDog;

                


                    double quantityEatenFoodCat = double.Parse(Console.ReadLine());
                    eatCat += quantityEatenFoodCat;

                    if (i == 3)
                    {
                        eatDog3Days += quantityEatenFoodDog;
                        eatCat3Days += quantityEatenFoodCat;
                        Days3Total = (eatDog3Days + eatCat3Days) * 0.10;

                    }

                

            }
            double TotalCatAndDog = eatDog + eatCat;
            double totalEatFood = (TotalCatAndDog / totalFood) * 100;

            double totalEatDog = (eatDog / TotalCatAndDog) * 100;

            double totalEatCat = (eatCat / TotalCatAndDog) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(Days3Total)}gr.");
            Console.WriteLine($"{totalEatFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalEatDog:f2}% eaten from the dog.");
            Console.WriteLine($"{totalEatCat:f2}% eaten from the cat.");
        }        
    }
}
