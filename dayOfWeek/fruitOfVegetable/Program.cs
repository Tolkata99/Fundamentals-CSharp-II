using System;

namespace fruitOfVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fV = Console.ReadLine();

            switch (fV)
            {
                case "banana":
                case "kiwi":
                case "apple":
                case "cherry":
                case "grapes":
                case "lemon":
                    Console.WriteLine("fruit");
                break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;


            }
               




        }  
        
            
                        
            
    }
}
