using System;
using System.Dynamic;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSea = int.Parse(Console.ReadLine());
            int numMontain = int.Parse(Console.ReadLine());

            int seaSum = 0;
            int montainSum = 0;

            double p1 = 0;
                double p2 = 0;
            while (true)
            {
                string vid = Console.ReadLine();
                if(vid == "Stop")
                {
                    break;
                }

                if (seaSum >= numSea && montainSum >= numMontain)
                {
                    break;
                }
                if (vid == "sea" && seaSum <= numSea)
                {
                    seaSum++;
                    if(seaSum <= numSea)
                    {
                        p1 += 680;
                    }
                }
                else if(vid == "mountain" && montainSum <= numMontain)
                {
                    montainSum++;
                    if(montainSum <= numMontain)
                    {
                        p2 += 499;
                    }
                }

                

                
                
            }
            

            if(seaSum >= numSea && montainSum >= numMontain)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {p1 + p2} leva.");
        }
    }
}
