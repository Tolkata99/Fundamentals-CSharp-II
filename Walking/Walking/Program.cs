using System;
using System.Collections.Generic;
using System.Linq;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            int goal = 0;

            while (command != "Going home");
            {
                
                int stepByDay = int.Parse(command);


                goal += stepByDay;

                if (goal >= 10000)
                {
                    Console.WriteLine(stepByDay);
                }
            }

            Console.WriteLine();
            
        }
    }
}
