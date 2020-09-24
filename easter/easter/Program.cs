using System;

namespace easter
{
    class Program
    {
        static void Main(string[] args)
        {
            int customers = int.Parse(Console.ReadLine());
            double prise = 0;
            double totalPrise = 0; ;
            int counterPurshasses = 0;
            for (int i = 1; i <= customers; i++)
            {
                
                while (true)
                {

                    string product = Console.ReadLine();

                    if(product == "Finish")
                    {
                        if(counterPurshasses % 2 == 0)
                        {
                            prise *= 0.8;
                        }
                        Console.WriteLine($"You purchased {counterPurshasses} items for {prise:f2} leva.");
                        totalPrise += prise;
                        prise = 0;
                        counterPurshasses = 0;
                        break;
                    }
                    counterPurshasses++;

                    if(product == "basket")
                    {
                        prise += 1.50;
                    }
                    else if(product == "wreath")
                    {
                        prise += 3.80;
                    }
                    else if(product == "chocolate bunny")
                    {
                        prise += 7;
                    }



                }
                
            }
            totalPrise /= customers; ;

            Console.WriteLine($"Average bill per client is: {totalPrise:f2} leva.");

        }
    }
}
