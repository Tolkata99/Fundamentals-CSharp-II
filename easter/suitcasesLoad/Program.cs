using System;
using System.Runtime.InteropServices.ComTypes;

namespace suitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double packPen = double.Parse(Console.ReadLine());
            double numMarkers = double.Parse(Console.ReadLine());
            double Medix = double.Parse(Console.ReadLine());
            double procentNamalenie = double.Parse(Console.ReadLine());

            double cenaHimikali = packPen * 5.80;
            double cenaMarkeri = numMarkers * 7.20;
            double cenaMedix = Medix * 1.20;
            double cenaVsichko = cenaHimikali + cenaMarkeri + cenaMedix;
            double total = cenaVsichko * 0.75;
            Console.WriteLine(($"{total:f3}"));
        }
    }
}
