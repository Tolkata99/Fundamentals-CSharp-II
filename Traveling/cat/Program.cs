using System;

namespace cat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int catMinetsWalk = int.Parse(Console.ReadLine());
            int numberWalk = int.Parse(Console.ReadLine());
            double caloriesOfDay = double.Parse(Console.ReadLine());

            int priseMinets = catMinetsWalk * numberWalk;
            double fireCalories = priseMinets * 5;
            double procentCaloriesDay = caloriesOfDay * 0.50;

            if(fireCalories >= procentCaloriesDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough." +
                    $" Burned calories per day: {fireCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough." +
                    $" Burned calories per day: {fireCalories}.");
            }

        }
    }
}
