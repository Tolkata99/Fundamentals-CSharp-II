using System;

namespace energy
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //Размерът на сета - текст с възможности: "small" или "big"
            //Брой на поръчаните сетове -цяло число в интервала[1 … 10000]
                string fruit = Console.ReadLine();
            string setOfSize = Console.ReadLine();
            int numberSetSold = int.Parse(Console.ReadLine());
            double priseSoldSet = 0;
            if (setOfSize == "small")
            {
                if(fruit == "Watermelon")
                {
                    priseSoldSet = 2 * 56;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "mango")
                {
                     priseSoldSet = 2 * 36.66;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "Pineapple")
                {
                     priseSoldSet = 2 * 42.10;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "Raspberry")
                {
                     priseSoldSet = 2 * 20;
                    priseSoldSet *= numberSetSold;
                }

            }
            else if (setOfSize == "big")
            {
                if (fruit == "Watermelon")
                {
                     priseSoldSet = 5 * 28.70;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "mango")
                {
                     priseSoldSet = 5 * 19.60;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "Pineapple")
                {
                     priseSoldSet = 5 * 24.80;
                    priseSoldSet *= numberSetSold;
                }
                else if (fruit == "Raspberry")
                {
                     priseSoldSet = 5 * 15.20;
                    priseSoldSet *= numberSetSold;
                }


            }
            if(priseSoldSet >= 400 && priseSoldSet <= 1000)
            {
                priseSoldSet *= 0.85;
            }
            else if (priseSoldSet > 1000)
            {
                priseSoldSet *= 0.50;
            }
            Console.WriteLine($"{priseSoldSet:f2}lv.");
        }
    }
}
