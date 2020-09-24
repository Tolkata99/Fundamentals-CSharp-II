using System;

namespace SumOfPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int protoChislo = 0;
            int neProsto = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                if(comand == "stop")
                {
                    break;
                }

               int number = int.Parse(comand);

                if(number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }
                else
                {

                
                       
                    bool isPrime = true;
                       
                    for (int i = 2; i <= number - 1; i++)
                       
                    {
                       
                        if(number % i == 0)
                       
                        {
                       
                            isPrime = false;
                       
                            break;
                       
                        }
                       
                    }
                       
                    if(isPrime)
                       
                    {
                       
                        protoChislo += number;
                       
                    }
                       
                    else
                       
                    {
                       
                        neProsto += number;
                       
                    }
                       

                       
                }



            }
            Console.WriteLine($"Sum of all prime numbers is: {protoChislo}");
            Console.WriteLine($"Sum of all non prime numbers is: {neProsto}");
        }
    }
}
