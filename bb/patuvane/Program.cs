using System;

namespace patuvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double pariNujniEkskurziq = double.Parse(Console.ReadLine());
            double nalichniPari = double.Parse(Console.ReadLine());
            int broqIzminialiDni = 0;
            int posledovatelniDni = 0;

            while (nalichniPari < pariNujniEkskurziq && posledovatelniDni < 5)
            {
                string comand = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                broqIzminialiDni++;

                if(comand == "spend")
                {
                    nalichniPari -= money;
                    posledovatelniDni++;
                }
                else if(comand == "save")
                {
                    nalichniPari += money;
                    posledovatelniDni = 0;
                }
                if(nalichniPari < 0)
                {
                    nalichniPari = 0;
                }

            }
            if(posledovatelniDni == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{broqIzminialiDni}");

            }
            if(nalichniPari >= pariNujniEkskurziq)
            {
                Console.WriteLine($"You saved the money for {broqIzminialiDni} days.");
            }

        }
    }
}
