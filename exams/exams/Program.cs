using System;

namespace exams
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първи ред – брой на хората.Цяло число в интервала[1…100]
            //2.Втори ред – такса вход. Реално число в интервала[0.00…50.00]
            //3.Трети ред – цена един за шезлонг. Реално число в интервала[0.00…50.00]
            //4.Четвърти ред – цена за един чадър. Реално число в интервала[0.00...50.00]

            int numPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double deckChair = double.Parse(Console.ReadLine());
            double oneUmbrella = double.Parse(Console.ReadLine());

            double priseEntrance = numPeople * entranceFee;
            double procentPeple = numPeople * 0.75;
            double priseDeckChair = Math.Ceiling(procentPeple) * deckChair;
            double umbrellaPrisePeople = numPeople * 0.50;
            double umbrellaPrise = Math.Ceiling(umbrellaPrisePeople) * oneUmbrella;

            double priseEnd = (umbrellaPrise) + priseEntrance + (priseDeckChair);
            Console.WriteLine($"{priseEnd:f2} lv.");

        }
    }
}
