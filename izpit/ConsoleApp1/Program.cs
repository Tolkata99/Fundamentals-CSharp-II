using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Брой дограми – цяло число в интервала[0..1000];
            //            Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
            //            Начин на получаване – текст
            //            С доставка - "With delivery"
            //Без доставка -"Without delivery"

            int broiDogrami = int.Parse(Console.ReadLine());
            string viddograma = Console.ReadLine();
            string nachinPoluchavane = Console.ReadLine();

            double prise = 0;
            if(viddograma == "90X130")
            {
                prise = broiDogrami * 110;
                if(broiDogrami >= 30 && broiDogrami <= 50)
                {
                    prise *= 0.95;
                }
                else if(broiDogrami > 50)
                {
                    prise *= 0.92;
                }
            }
            else if(viddograma == "100X150")
            {
                prise = broiDogrami * 140;
                if (broiDogrami >= 40 && broiDogrami <= 80)
                {
                    prise *= 0.94;
                }
                else if (broiDogrami > 80)
                {
                    prise *= 0.90;
                }
            }
            else if (viddograma == "130X180")
            {
                prise = broiDogrami * 190;
                if (broiDogrami >= 20 && broiDogrami <= 50)
                {
                    prise *= 0.93;
                }
                else if (broiDogrami > 50)
                {
                    prise *= 0.88;
                }
            }
            else if(viddograma == "200X300")
            {
                prise = broiDogrami * 250;
                if (broiDogrami >= 25 && broiDogrami <= 50)
                {
                    prise *= 0.91;
                }
                else if (broiDogrami > 50)
                {
                    prise *= 0.86;
                }
            }
            if(nachinPoluchavane == "With delivery")
            {
                prise += 60;
            }

            if(broiDogrami >= 99)
            {
                prise *= 0.96;
            }

            if(broiDogrami <= 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{prise:f2} BGN");
            }
        }
    }
}
