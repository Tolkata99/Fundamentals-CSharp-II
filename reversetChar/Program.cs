using System;

namespace reversetChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char seconds = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());


            Console.WriteLine($"{first}{seconds}{third}");
        }
    }
}
