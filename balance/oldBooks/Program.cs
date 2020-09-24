using System;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            bool flase = false;
            string libraryBook = Console.ReadLine();
            int broi = 0;

            while (libraryBook != "No More Books")
            {
                if(favoriteBook == libraryBook)
                {
                    flase = true;
                    break;
                }
                broi++;

                

                libraryBook = Console.ReadLine();
            }
            if (flase)
            {
                Console.WriteLine($"You checked {broi}books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {broi} books");



            }

        }
    }
}
