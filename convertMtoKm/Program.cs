using System;

namespace convertMtoKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());

            meter /= 1000;

            Console.WriteLine($"{meter:f2}");

        }
    }
}
