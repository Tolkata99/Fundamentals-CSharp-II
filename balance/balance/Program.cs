using System;

namespace balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine;
            int counter = 0;
            bool isTrue = false;

            string newReadBooks = Console.ReadLine();

            while (newReadBooks != "No More Books")
            {
                if(newReadBooks == favoriteBook)
                {
                    isTrue = true;
                    break;
                }
                counter++;
                newReadBooks = Console.ReadLine();
            }
            if(isTrue)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
