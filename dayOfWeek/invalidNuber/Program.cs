using System;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double quantityPrice = 0.0;


            if (dayWeek == "Monday" ||
                dayWeek == "Tuesday" ||
                dayWeek == "Wednesday" ||
                dayWeek == "Thursday" ||
                dayWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    quantityPrice = 2.50;
                }
                else if (fruit == "apple")
                {
                    quantityPrice = 1.20;

                }
                else if (fruit == "orange")
                {
                    quantityPrice = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    quantityPrice = 1.45;

                }
                else if (fruit == "kiwi")
                {
                    quantityPrice = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    quantityPrice = 5.50;
                }
                else if (fruit == "grapes")
                {
                    quantityPrice = 3.85;
                }
                else
                    Console.WriteLine("error");

                Console.WriteLine($"{quantity * quantityPrice:f2}");


                //плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85




            }
            else if (dayWeek == "Saturday" ||
                dayWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    quantityPrice = 2.70;
                }
                else if (fruit == "apple")
                {
                    quantityPrice = 1.25;

                }
                else if (fruit == "orange")
                {
                    quantityPrice = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    quantityPrice = 1.60;

                }
                else if (fruit == "kiwi")
                {
                    quantityPrice = 3.0;
                }
                else if (fruit == "pineapple")
                {
                    quantityPrice = 5.60;
                }
                else if (fruit == "grapes")
                {
                    quantityPrice = 4.20;
                }
                else
                    Console.WriteLine("error");

                Console.WriteLine($"{quantity * quantityPrice:f2}");

            }
            else
            {
                Console.WriteLine("error");
            }




        }
    }
}