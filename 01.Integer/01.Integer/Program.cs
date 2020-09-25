using System;

namespace _01.Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thurtee = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            first += second;

            first /= thurtee;

            first *= four;

            Console.WriteLine(first);
        }
    }
}
