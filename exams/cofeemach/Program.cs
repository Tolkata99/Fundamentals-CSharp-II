using System;

namespace cofeemach
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Входът се чете от конзолата и се състои от три реда:
            //            Първи ред -напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            //Втори ред -захар - текст  с възможности "Without", "Normal" или "Extra"
            //Трети ред -брой напитки - цяло число в интервала[1… 50]

            string napitka = Console.ReadLine();
            string shugarOn = Console.ReadLine();
            int numNapitki = int.Parse(Console.ReadLine());

            //          Еспресо 0.90 лв./ бр.    1 лв. / бр.  1.20 лв. / бр.
            //Капучино    1.00 лв. / бр.   1.20 лв. / бр.   1.60 лв. / бр.
            //  Чай 0.50 лв. / бр.   0.60 лв. / бр.   0.70 лв. / бр.
            double priseExpresso = 0;
            
            
            if (shugarOn == "Without") 
            {
                if(napitka == "Espresso")
                {
                    priseExpresso += 0.90;
                }
                else if (napitka == "Cappuccino")
                {
                    priseExpresso += 1;
                }
                else if (napitka == "Tea")
                {
                    priseExpresso += 0.50;
                }

                priseExpresso *= 0.65;
                // При избрана напитка без захар има 35 % отстъпка.

            }
            else if(shugarOn == "Normal")
            {

                if (napitka == "Espresso")
                {
                    priseExpresso += 1;
                    
                    
                }
                else if (napitka == "Cappuccino")
                {
                    priseExpresso += 1.20;
                }
                else if (napitka == "Tea")
                {
                     priseExpresso += 0.60;
                }
            }
            else if (shugarOn == "Extra")
            {

                if (napitka == "Espresso")
                {
                    priseExpresso += 1.20;
                }
                else if (napitka == "Cappuccino")
                {
                    priseExpresso += 1.60;
                }
                else if (napitka == "Tea")
                {
                    priseExpresso += 0.70;
                }
            }

            if (napitka == "Espresso")
            {
                
                if (numNapitki >= 5)
                {
                    priseExpresso *= 0.75;
                }
            }
            double result = numNapitki * priseExpresso;
            if (result > 15)
            {
                result *= 0.80;
            }
            Console.WriteLine($"You bought {numNapitki} cups of {napitka} for {result:f2} lv.");
        }
    }
}
