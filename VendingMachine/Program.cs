using System;

namespace vending.Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double sumOfMoney = 0;
            while(money != "Start")
            {
                double curentCoin = double.Parse(money);
                bool isValid = (curentCoin == 0.1 ||
                               curentCoin == 0.2 ||
                               curentCoin == 0.5 ||
                               curentCoin == 1 ||
                               curentCoin == 2 );
                               
                if (isValid)
                {
                    sumOfMoney += curentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {curentCoin}");
                }


                money = Console.ReadLine();
            }
            double spendeMoney = 0;

            string product = Console.ReadLine();
            //“Water”, “Crisps”, “Soda”, “Coke”. 
            //2.0,   0.7,   1.5,   0.8,   1.0 
            while (product != "End")
            {
                spendeMoney = 0;
                switch(product)
                {
                    case "Nuts":
                        spendeMoney += 2.0;
                        break;
                    case "Water":
                        spendeMoney += 0.7;
                        break;
                    case "Crisps":
                        spendeMoney += 1.5;
                        break;
                    case "Soda":
                        spendeMoney += 0.8;
                        break;
                    case "Coke":
                        spendeMoney += 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                bool isTry = product == "Nuts" ||
                             product == "Water" ||
                             product == "Crisps" ||
                             product == "Soda" || 
                             product == "Coke";
                            
                if (sumOfMoney >= spendeMoney)
                {
                    sumOfMoney -= spendeMoney;
                    if (isTry)
                    {
                        Console.WriteLine($"Purchased {product. ()}");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumOfMoney:f2}");
           

        }
    }
}
