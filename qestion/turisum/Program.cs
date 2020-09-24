using System;

namespace turisum
{
    class Program
    {
        static void Main(string[] args)
        {
            //            На първи ред – бюджетът - реално число в интервала[1.00… 100000.00]
            //След това поредица от два реда(до получаване на команда "Stop" или при заявка за купуване на продукт, чиято стойност е по-висока от наличния бюджет) :
            //Име на продукта – текст
            //Цена на продукта – реално число в интервала[1.00… 5000.00]

            double butget = double.Parse(Console.ReadLine());
            string comand = Console.ReadLine();

            double usd = 0;

            int countProduct = 0;
            while (comand != "Stop")
            {
                double priseProduct = double.Parse(Console.ReadLine());
                countProduct++;
                if (countProduct % 3 == 0)
                {
                    priseProduct /= 2;
                }
                butget -= priseProduct;
               
               

                comand = Console.ReadLine();
                usd += priseProduct;

                if(butget < 0)
                {
                    break;
                }

            }
            if(comand == "Stop")
            {
                Console.WriteLine($"You bought {countProduct} products for {usd:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(butget):f2} leva!");
            }
        }
    }
}
