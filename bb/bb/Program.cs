using System;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {

            int falsGrade = int.Parse(Console.ReadLine());

            int nezadovolitelni = 0;
            int broqchreshenie = 0;
            double sumataVsichkiOtcenki = 0;
            string koqEposlednataZadacha = String.Empty;
            bool Isfailed = true;
            int broqchotcenki = 0;
            while (nezadovolitelni < falsGrade)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    Isfailed = false;
                    break;
                }
                int otcenka = int.Parse(Console.ReadLine());
                if (otcenka <= 4)
                {
                    nezadovolitelni++;
                }
                broqchreshenie++;
                sumataVsichkiOtcenki += otcenka;
                broqchotcenki++;
                koqEposlednataZadacha = problemName;


            }
            if (Isfailed)
            {
                Console.WriteLine($"You need a break, {nezadovolitelni} poor grades.");

            }
            else
            {
                Console.WriteLine($"Average score: {sumataVsichkiOtcenki / broqchotcenki:f2}");
                Console.WriteLine($"Number of problems: {broqchreshenie}");
                Console.WriteLine($"Last problem: {koqEposlednataZadacha}");
            }

        }
    }
}

