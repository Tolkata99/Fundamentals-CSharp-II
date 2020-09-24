using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string intput = Console.ReadLine();

            while(intput != password)
            {
                intput = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {username}");

        }
    }
}
