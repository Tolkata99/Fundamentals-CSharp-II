using System;

namespace vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            while (true)
            {
                string destinations = Console.ReadLine();   
                if (destinations == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                
                double sum1 = 0;
                while(budget > sum1)
                {
                    double currentSum = double.Parse(Console.ReadLine());
                    sum1 += currentSum;

                }




                Console.WriteLine($"Going to {destinations}!");
                
            }

        }
    }
}
