using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int CapacityPeople = int.Parse(Console.ReadLine());

            int couter = 0;

            while (true)
            {
                if(people <= 0)
                {
                    break;
                }
                people -= CapacityPeople;
                couter++;
            }

            Console.WriteLine(couter);



        }   
    }
}
