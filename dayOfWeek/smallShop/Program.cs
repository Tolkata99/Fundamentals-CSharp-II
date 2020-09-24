using System;

namespace smallShop
{
    class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            string city = Console.ReadLine();
           
            double cena = double.Parse(Console.ReadLine());

            double productPrize = 0.0;
            
            if (city == "Sofia")
            {
                if (product == "coffee") 
                {
                    productPrize = 0.50;
                }
                

                else if (product == "water")
                {
                    productPrize =  0.80;
                }
                else if (product == "beer")
                {
                    productPrize = 1.20;
                }
                else if (product == "sweets")
                {
                    productPrize =  1.45;
                }
                else if (product == "peanuts")
                {
                    productPrize = 1.60;

                }

                //Plovdiv	0.40	0.70	1.15	1.30	1.50

            }

            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productPrize = 0.40;
                }


                else if (product == "water")
                {
                    productPrize = 0.70;
                }
                else if (product == "beer")
                {
                    productPrize = 1.15;
                }
                else if (product == "sweets")
                {
                    productPrize = 1.30;
                }
                else if (product == "peanuts")
                {
                    productPrize = 1.50;

                }

            }
            //Varna	0.45	0.70	1.10	1.35	1.55


            if (city == "Varna")
            {
                if (product == "coffee")
                {
                    productPrize = 0.45;
                }


                else if (product == "water")
                {
                    productPrize = 0.70;
                }
                else if (product == "beer")
                {
                    productPrize = 1.10;
                }
                else if (product == "sweets")
                {
                    productPrize = 1.35;
                }
                else if (product == "peanuts")
                {
                    productPrize = 1.55;

                }
                
            }


            double n = productPrize * cena;
            Console.WriteLine(n);

        }
    }
}
