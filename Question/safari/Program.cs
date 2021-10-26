using System;

namespace safari
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Бюджет – реално число в интервала[0.00… 10000.00]
            //Колко литра гориво ще са им нужни – реално число в интервала[1.00… 50.00]
            //Ден от седмицата – текст с възможности "Saturday" и "Sunday"

            double budget = double.Parse(Console.ReadLine());
            double literNextToAfrika = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double priseBenzin = literNextToAfrika * 2.10;
            double priseSafaryManGorivo = priseBenzin + 100;

            if(dayOfWeek == "Saturday")
            {
                priseSafaryManGorivo *= 0.90;

            }
            else if(dayOfWeek == "Sunday")
            {
                priseSafaryManGorivo *= 0.80;
            }

            if(budget > priseSafaryManGorivo)
            {
                budget -= priseSafaryManGorivo;
                Console.WriteLine($"Safari time! Money left: {budget:f2} lv. ");
            }
            else
            {
                budget -= priseSafaryManGorivo;
                Console.WriteLine($"Not enough money! Money needed: {Math.Abs(budget):f2} lv.");
            }

        }
    }
}
