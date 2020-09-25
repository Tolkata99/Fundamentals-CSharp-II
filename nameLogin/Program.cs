using System;

namespace nameLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string sign = Console.ReadLine();

            string result = firstName + sign + lastName;

            Console.WriteLine($"{result}");
        }
    }
}
