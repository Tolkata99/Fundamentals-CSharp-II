using System;

namespace stupki
{
    class Program
    {
        static void Main(string[] args)
        {
            string comandAndsteps = Console.ReadLine();
            int stepsPrise = 0;
            while (comandAndsteps != "Going home")
            {
                int steps = int.Parse(comandAndsteps);
                stepsPrise += steps;

                comandAndsteps = Console.ReadLine();

                if(stepsPrise >= 10000 && comandAndsteps != "Going home")
                {
                    break;
                }


            }
            if(comandAndsteps == "Going home")
            {
                comandAndsteps = Console.ReadLine();
                int stepshome = int.Parse(comandAndsteps);
                stepsPrise += stepshome;
                if(stepsPrise >= 10000)
                {
                    stepsPrise -= 10000;

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsPrise} steps over the goal!");
                }
                else
                {
                    stepsPrise -= 10000;
                    Console.WriteLine($"{Math.Abs(stepsPrise)} more steps to reach goal.");
                    
                }
                
            }
            else
            {
                if (stepsPrise >= 10000)
                {
                    stepsPrise -= 10000;

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsPrise} steps over the goal!");
                }
                else
                {
                    stepsPrise -= 10000;
                    Console.WriteLine($"{Math.Abs(stepsPrise)} more steps to reach goal.");

                }
            }
        }
    }
}
