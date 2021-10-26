using System;
using System.Xml;

namespace serials

{
    class Program
    {
        static void Main(string[] args)
        {
            //            Бюджет - реално  число в интервала[10.0… 100.0]
            //Брой сериали -n - цяло положително число в интервала[1… 10]
            //За всеки сериал се четат по два реда:
            //Име на сериал - текст
            //Цена за сериал - реално  число в интервала[1.0… 15.0]

            double budget = double.Parse(Console.ReadLine());
            int numSeries = int.Parse(Console.ReadLine());

            

            double Thrones = 0;
            double lucifer = 0;
            double protector = 0;
            double totaldrama = 0;
            double area = 0;
            double other = 0;
            

            for (int i = 1; i <= numSeries; i++)
            {
                string nameSeries = Console.ReadLine();
                double priseSeries = double.Parse(Console.ReadLine());


                if(nameSeries == "Thrones")
                {
                    Thrones += priseSeries;
                    Thrones *= 0.50;
                }
                else if(nameSeries == "Lucifer")
                {
                    lucifer += priseSeries;
                    lucifer *= 0.60;
                }
                else if(nameSeries == "Protector")
                {
                    protector += priseSeries;
                    protector *= 0.70;
                }
                else if(nameSeries == "TotalDrama")
                {
                    totaldrama += priseSeries;
                    totaldrama *= 0.80;
                }
                else if(nameSeries == "Area")
                {
                    area += priseSeries;
                    area *= 0.90;
                }
                else
                {
                    other += priseSeries;
                }
            }

            double result = Thrones + lucifer + protector + totaldrama + area + other;
            if(budget >= result)
            {
                double milena = budget - result;
                Console.WriteLine($"You bought all the series and left with {milena:f2} lv.");
            }
            else
            {
                double milena1 = budget - result;
                Console.WriteLine($"You need {Math.Abs(milena1):f2} lv. more to buy the series!");
            }


        }
    }
}
