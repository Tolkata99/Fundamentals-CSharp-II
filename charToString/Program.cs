using System;

namespace charToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());

            //]string text = letter + letterOne + letterTwo;

            Console.WriteLine($"{letter}{letterOne}{letterTwo}");

        }
    }
}
