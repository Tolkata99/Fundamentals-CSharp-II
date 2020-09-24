using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int loshiOcenki = int.Parse(Console.ReadLine());
            string imeZadacha = Console.ReadLine();
            int otcenka = int.Parse(Console.ReadLine());
            double sredenUspeh = 0;
            double pogolemi4 = 0;
            double broiloshiotcenki = 0;
            double broiotcenki = 0;
            double result = 0;
            int broizadachi = 0;
            
            
            while (imeZadacha != "Enough")
            {
                imeZadacha = Console.ReadLine();
                otcenka = Console.ReadLine();
                broizadachi++;
               
                broiotcenki++;
                sredenUspeh += otcenka;

                if (otcenka > 4)
                {
                    pogolemi4++;
                }
                else
                {
                    broiloshiotcenki++;
                }                  
            }
            if (loshiOcenki == broiloshiotcenki)
            {
                Console.WriteLine($"You need a break, {broiloshiotcenki} poor grades.");
                
            }
            if (imeZadacha == "Enough")
            {
                result = sredenUspeh / broiotcenki;
                Console.WriteLine($"Average score: {result:f2}");
                Console.WriteLine($"Number of problems: {broizadachi}");
                Console.WriteLine($"Last problem: {imeZadacha}");
            }

        }
    }
}
