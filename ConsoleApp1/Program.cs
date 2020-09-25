using System;

namespace poundToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ///1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            ///
            

            int years = 100 * centuries;
            int days = (int)(365.2422F * years);
            int hours = 24 * days;
            int minutes = 60 * hours;


            Console.WriteLine($"{centuries} centuries = {years} years = {days}" +
                $" days = {hours} hours = {minutes} minutes");



        }
    }
}
