using System;

namespace pochivka
{
    class Program
    {
        static void Main(string[] args)
        {
            double butget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double butgetPrise = 0;
            string destinaciq = string.Empty;
            string spane = string.Empty;
            if (butget >= 1000)
            {
                butgetPrise = butget * 0.90;
                destinaciq = "Europe";
                spane = "hotel";
            }

            else if (butget <= 100)
            {
                if (season == "summer")
                {
                    butgetPrise = butget * 0.30;
                    spane = "camp";
                }
                else if (season == "winter")
                {
                    butgetPrise = butget * 0.70;
                    spane = "hotel";
                }
                destinaciq = "Bulgaria";
            }
            else if (butget <= 1000)
            {
                if (season == "summer")
                {
                    butgetPrise = butget * 0.40;
                    spane = "camp";
                }
                else if (season == "winter")
                {
                    butgetPrise = butget * 0.80;
                    spane = "hotel";
                }
                destinaciq = "Balkans";

            }
            Console.WriteLine($"Somewhere in { destinaciq} ");
            Console.WriteLine($"{spane} – {butgetPrise:f2}");
        }
    }
}
