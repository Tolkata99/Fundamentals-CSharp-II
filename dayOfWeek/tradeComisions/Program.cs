using System;

namespace tradeComisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double obemProdajbi = double.Parse(Console.ReadLine());

            
            double result = 0.0;
            if (town == "Sofia")
            {
                if (0 <= obemProdajbi && obemProdajbi <= 500)
                {
                    result = obemProdajbi * 0.05;
                }
                else if (500 <= obemProdajbi && obemProdajbi <= 1000)
                {
                    result = obemProdajbi * 0.07;
                }
                else if (1000 <= obemProdajbi && obemProdajbi <= 10000)
                {
                    result = obemProdajbi * 0.08;
                }
                else if (obemProdajbi >= 10000)
                {
                    result = obemProdajbi * 0.12;
                }
                
                

            }
            else if (town == "Varna")
            {
                if (0 <= obemProdajbi && obemProdajbi <= 500)
                {
                    result = obemProdajbi * 0.045;
                }
                else if (500 <= obemProdajbi && obemProdajbi <= 1000)
                {
                    result = obemProdajbi * 0.075;
                }
                else if (1000 <= obemProdajbi && obemProdajbi <= 10000)
                {
                    result = obemProdajbi * 0.10;
                }
                else if (obemProdajbi >= 10000)
                {
                    result = obemProdajbi * 0.13;
                }
               


                
            }
            else if (town == "Plovdiv")
            {
                if (0 <= obemProdajbi && obemProdajbi <= 500)
                {
                    result = obemProdajbi * 0.055;
                }
                else if (500 <= obemProdajbi && obemProdajbi <= 1000)
                {
                    result = obemProdajbi * 0.08;
                }
                else if (1000 <= obemProdajbi && obemProdajbi <= 10000)
                {
                    result = obemProdajbi * 0.12;
                }
                else if (obemProdajbi >= 10000)
                {
                    result = obemProdajbi * 0.145;
                }
 
            }
            


            if(result > 0)
            {
                

                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }







        }
    }
}
