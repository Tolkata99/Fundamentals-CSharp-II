using System;

namespace cinemaStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            while (true)
            {
                string nameActior = Console.ReadLine();
                if(nameActior == "ACTION")
                {
                    break;
                }
                int nameActiorCount = nameActior.Length;
                
                if(nameActiorCount <= 15)
                {
                    Double salaryActior = double.Parse(Console.ReadLine());
                    budget -= salaryActior;
                }
                else
                {
                    double longName = budget * 0.20;
                    budget -= longName;
                }

                if(budget < 0)
                {
                    break;
                }
               

            }
            if(budget < 0)
            {
                Console.WriteLine($"We need { Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
