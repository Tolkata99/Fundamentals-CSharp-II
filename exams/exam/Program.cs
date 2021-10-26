using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално от конзолата се прочита броя на авиокомпаниите – цяло число в интервала[1… 20]
            //След това за всяка авиокомпания се прочита:
            //            Името на авиокомпанията – текст
            //            До получаване на командата "Finish" се чете:
            //Брой пътници на полет  – цяло число в интервала[1... 360]

            int numAvio = int.Parse(Console.ReadLine());
            double sumPeople = 0;
            int suma = 0;
            double max = double.MinValue;
            string max1 = " ";
            for (int i = 1; i <= numAvio; i++)
            {
                string nameAvio = Console.ReadLine();



                while (true)
                {
                   
                    if (nameAvio == "Finish")
                    {
                        break;
                    }
                    if(suma == numAvio)
                    {
                        break;
                    }
                    
                    
                        int numPeple = int.Parse(Console.ReadLine());
                        sumPeople += numPeple;
                    suma++;

                    
                }
                
                sumPeople /= numAvio;
                if(sumPeople > max)
                {
                    max1 = nameAvio;
                    max = sumPeople;
                }
                Console.WriteLine($"{nameAvio}: {sumPeople} passengers.");
                sumPeople = 0;
                suma = 0;
                
            }
            Console.WriteLine($"{max1} has most passengers per flight: {max}");
            

        }
    }
}
