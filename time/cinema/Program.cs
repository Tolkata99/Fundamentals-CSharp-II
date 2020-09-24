using System;
using System.IO;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)

        {
            int student = 0;
            int standart = 0;
            int kid = 0;
            int allPeople = 0;
            while (true)
            {
                string comandNameMovie = Console.ReadLine();
                string nameMovie = comandNameMovie;
                if(comandNameMovie != "Finish")
                {
                    break;
                }

                int freePlases = int.Parse(Console.ReadLine());

                while (comandNameMovie != "End")
                {
                    comandNameMovie = Console.ReadLine();
                    
                    

                    if(comandNameMovie == "student")
                    {
                        student++;
                    }
                    else if (comandNameMovie == "standard")
                    {
                        standart++;
                    }
                    else if (comandNameMovie == "kid")
                    {
                        kid++;
                    }
                    allPeople++;
                    if(allPeople == freePlases)
                    {
                        break;
                    }

                }
                double result = (freePlases * 1.0) / allPeople * 100 ;
                double sumStudent = (freePlases * 1.0) / student * 100;
                double sumStandart = (freePlases * 1.0) / standart * 100;
                double sumKids = (freePlases * 1.0) / kid * 100;
                Console.WriteLine($"{nameMovie} - {result:f2} % full.");
                
                Console.WriteLine($"Total tickets: {allPeople}");
                Console.WriteLine($"{sumStudent:f2} % student tickets.");
                Console.WriteLine($"{sumStandart:f2} % standard tickets.");
                Console.WriteLine($"{sumKids:f2} % kids tickets.");
            }
        }
    }
}
