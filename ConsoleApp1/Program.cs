using System;

namespace poundToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());

            ///1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            ///
            byte centuries = number;
            ushort years1 = 100;
            uint days1 = 36524;
            ulong hours1 = 876576;
            ulong minutes1 = 52594560;

            double years = years1 * centuries;
            double days = days1 * centuries;
            double hours = hours1 * centuries;
            double minutes = minutes1 * centuries;


            Console.WriteLine($"{centuries} centuries = {years} years = {days}" +
                $" days = {hours} hours = {minutes} minutes");



        }
    }
}
