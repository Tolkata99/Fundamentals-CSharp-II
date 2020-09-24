using System;

namespace qestion
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumPrise = 0;
            for (int day = 1; day <= days; day++)
            {
                double sumparking = 0;
                for (int hour = 1; hour <= hours; hour++)
                {
                    if(day % 2 == 0 && hour % 2 == 1)
                    {
                        sumparking += 2.50;
                        sumPrise += 2.50;
                    }
                    else if(day % 2 == 1 && hour % 2 == 0)
                    {
                        sumparking += 1.25;
                        sumPrise += 1.25;
                    }
                    else
                    {
                        sumparking += 1;
                        sumPrise += 1;
                    }
                    
                }
                Console.WriteLine($"Day: {day} - {sumparking:f2} leva");
            }
            Console.WriteLine($"Total: {sumPrise:f2} leva");
        }
    }
}
