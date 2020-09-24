using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ⦁	Бюджет на групата – цяло число в интервала[1…8000]
            //  ⦁	Сезон –  текст: "Spring", "Summer", "Autumn", "Winter"
            // ⦁	Брой рибари – цяло число в интервала[4…18]

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisheMan = int.Parse(Console.ReadLine());

            double totPrise = 0.0;
            //"Spring", "Summer", "Autumn", "Winter"

            if (season == "Spring")
            {
                totPrise = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totPrise = 4200;
            }
            else if (season == "Winter")
            {
                totPrise = 2600;
            }


            if (fisheMan <= 6)
            {
                totPrise = totPrise * 0.90;
            }
            else if (fisheMan >= 7 && fisheMan <= 11)
            {
                totPrise = totPrise * 0.85;
            }
            else if (fisheMan >= 12)
            {
                totPrise = totPrise * 0.75;
            }
            if (season == "Winter" || season == "Summer" || season == "Spring")
            {
                if (fisheMan % 2 == 0)
                {
                    totPrise = totPrise * 0.95;
                }
            }

            double moneyleft = budget - totPrise;
            string output = string.Empty;


            if (budget >= totPrise)
            {
                output = $"Yes! You have {moneyleft:f2} leva left.";

            }
            else
            {

                output = $"Not enough money! You need {Math.Abs(moneyleft):f2} leva.";
            }

            Console.WriteLine(output);


        }
    }
}
