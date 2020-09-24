using System;

namespace familiTryp
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            //Брой нощувки – цяло число в интервала[0 … 1000]
            //Цена за нощувка – реално число в интервала[1.00 … 500.00]
            //Процент за допълнителни разходи – цяло число в интервала[0 … 100]

            double butgetFamily = double.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            double priseNight = double.Parse(Console.ReadLine());
            int procentCosts = int.Parse(Console.ReadLine());

            if(numNights > 7)
            {
                priseNight *= 0.95;
            }
            priseNight *= numNights;

            double procentcoss = butgetFamily * procentCosts / 100;

            double result = priseNight + procentcoss;

            if(result <= butgetFamily)
            {
                butgetFamily -= result;
                Console.WriteLine($"Ivanovi will be left with {butgetFamily:f2} leva after vacation.");
            }
            else
            {
                result -= butgetFamily;
                Console.WriteLine($"{result:f2} leva needed.");


            }
            


        }
    }
}
