using System;
using System.Diagnostics.Tracing;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            int flat = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            for (int i = flat; i >= 1; i--)
            {
                for (int r = 0; r < room; r++)
                {
                    if (i == flat)
                    {
                        Console.Write($"L{i}{r} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{r} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{r} ");
                    }

                    
                    
                }
                Console.WriteLine();
                double sumStudent = (student * 1.0) / freePlases * 100;
                double sumStandart = (standard * 1.0) / freePlases * 100;
                double sumKids = (kid * 1.0) / freePlases * 100;
                Console.WriteLine($"Total tickets: {priseTicket}");
                Console.WriteLine($"{sumStudent:f2} % student tickets.");
                Console.WriteLine($"{sumStandart:f2} % standard tickets.");
                Console.WriteLine($"{sumKids:f2} % kids tickets.");


            }
        }
    }
}

