using System;

namespace wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int visochinaLetva = int.Parse(Console.ReadLine());
            int jelanaVisochina = int.Parse(Console.ReadLine());

            int counterLossSkok = 0;
            int counterBroiSKokove = 0;
            while (true)
            {
                visochinaLetva -= 30;

                counterLossSkok = 0;
                    counterBroiSKokove++;
                for (int i = 1; i <= 3; i++)
                {
                    int visochinaSkok = int.Parse(Console.ReadLine());
                    if(visochinaLetva > visochinaSkok)
                    {
                        counterLossSkok++;
                            if(counterLossSkok == 3)
                            {
                            Console.WriteLine($"Tihomir failed at {visochinaSkok}cm after {counterBroiSKokove} jumps.");
                               break;
                            }
                    }
                    else
                    {
                        visochinaLetva += 5;
                        continue;
                    }
                }
                
                
               



            }
        }
    }
}
