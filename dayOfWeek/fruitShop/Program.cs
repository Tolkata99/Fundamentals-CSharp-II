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
                    quantityPrice = quantity * 2.50;
                }
                else if (fruit == "apple")
                {
                    quantityPrice = quantity*1.20;

                }
                else if (fruit == "orange")
                {
                    quantityPrice = quantity* 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    quantityPrice = quantity*1.45;

                }
                else if (fruit == "kiwi")
                {
                    quantityPrice = quantity*2.70;
                }
                else if (fruit == "pineapple")
                {
                    quantityPrice = quantity* 5.50;
                }
                else if (fruit == "grapes")
                {
                    quantityPrice = quantity* 3.85;
                }

                double result = quantity * quantityPrice;

                //плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85




            }
            if (dayWeek == "Saturday" ||
             dayWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    quantityPrice = quantity*2.70;
                }
                else if (fruit == "apple")
                {
                    quantityPrice = quantity* 1.25;

                }
                else if (fruit == "orange")
                {
                    quantityPrice = quantity* 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    quantityPrice = quantity*1.60;

                }
                else if (fruit == "kiwi")
                {
                    quantityPrice = quantity* 3.0;
                }
                else if (fruit == "pineapple")
                {
                    quantityPrice = quantity*5.60;
                }
                else if (fruit == "grapes")
                {
                    quantityPrice = quantity*4.20;
                }

                
            }

            if (quantityPrice > 0)
            {
                Console.WriteLine($"{quantityPrice:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }





        }
    }
}