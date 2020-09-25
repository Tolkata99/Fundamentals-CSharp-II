using System;

namespace convertMtoKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());

            decimal result = meter / 1000.0M;

            Console.WriteLine($"{result:f2}");

        }
    }
}
