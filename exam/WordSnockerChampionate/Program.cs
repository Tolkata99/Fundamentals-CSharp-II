using System;
using System.Runtime.ConstrainedExecution;

namespace fitness


{
    class Program
    {
        static void Main(string[] args)
        {
            //За всеки един посетител на отделен ред – дейността във фитнеса – текст
            //    ("Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar")
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinBar = 0;
            int proteinShake = 0;

            double procentTrainigs = 0;
            double procetnBuy = 0;
            int visitursFitness = int.Parse(Console.ReadLine());
            for (int i = 1; i <= visitursFitness; i++)
            {
                string activity = Console.ReadLine();
                if(activity == "Back")
                {
                    back++;
                }
                else if(activity == "Chest")
                {
                    chest++;
                }
                else if(activity == "Legs")
                {
                    legs++;
                }
                else if(activity == "Abs")
                {
                    abs++;
                }
                else if(activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if(activity == "Protein bar")
                {
                    proteinBar++;
                }

                double trainings = abs + legs + chest + back;
                procentTrainigs = trainings / visitursFitness * 100;

                double visitorsBuyProtein = proteinBar + proteinShake;
                procetnBuy = visitorsBuyProtein / visitursFitness * 100;

            }

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{procentTrainigs:f2}% - work out");
            Console.WriteLine($"{procetnBuy:f2}% - protein");

            

        }
    }
}
