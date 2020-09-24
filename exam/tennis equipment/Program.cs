using System;
using System.Threading;

namespace skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesConstola = int.Parse(Console.ReadLine());
            int secondControla = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double secondOf100M = double.Parse(Console.ReadLine());

            double seconds = minutesConstola * 60 + secondControla;

            double timeDegreases = lenght / 120;
            double totalDegreasesTime = timeDegreases * 2.5;
            double timeMarin = (lenght / 100) * secondOf100M - totalDegreasesTime;

            if(seconds > timeMarin)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else if(timeMarin > seconds)
            {
                 double result = timeMarin - seconds;
                Console.WriteLine($"No, Marin failed! He was {result:f3} second slower.");
            }
        }
    }
}
