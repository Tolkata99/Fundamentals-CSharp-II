using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string project = (Console.ReadLine());
            int numOfRows = int.Parse(Console.ReadLine());
            int numOfColumns = int.Parse(Console.ReadLine());

            double income = 0;

            if(project == "Premiere")
            {
                income = numOfRows * numOfColumns * 12;
            }
            else if(project == "Normal")
            {
                income = numOfRows * numOfColumns * 7.50;
            }
            else if(project == "Discount")
            {
                income = numOfRows * numOfColumns * 5;
            }

            Console.WriteLine($"{income:f2}");

        }
    }
}
