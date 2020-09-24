using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double totPriseStudio = 0;
            double totPriseApp = 0;
            if (month == "May" || month == "October")
            {
                totPriseStudio =night * 50;
                totPriseApp = night * 65;
                if(night > 7 && night <= 14)
                {
                    totPriseStudio *= 0.95;
                }
                else if (night > 14)
                {
                    totPriseStudio *= 0.70;
                }

            }
            else if(month == "June" || month == "September")
            {
                totPriseStudio = night * 75.20;
                totPriseApp = night * 68.70;

                if (night > 14)
                {
                    totPriseStudio *= 0.80;

                }

            }
            else if(month == "July" || month == "August")
            {
                totPriseStudio = night * 76;
                totPriseApp = night * 77;


            }
            if (night > 14)
            {
                totPriseApp *= 0.90;

            }

            Console.WriteLine($"Apartment: {totPriseApp:f2} lv.");
            Console.WriteLine($"Studio: {totPriseStudio:f2} lv.");


        }
    }
}
