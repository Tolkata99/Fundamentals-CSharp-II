using System;

namespace premestvane
{
    class Program
    {
        static void Main(string[] args)
        {
            string books = Console.ReadLine();
            string curenbooks = Console.ReadLine();

            bool isFound = false;
            int broqch = 0;

            while (curenbooks != "No more books")
            {
                curenbooks = Console.ReadLine();
                if (curenbooks == books)
                {
                    isFound = true;
                    break;
                }
                broqch++;
                

                


            }
            if (isFound)
            {
                Console.WriteLine($"You checked {broqch} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {broqch} books.");

            }



        }
    }
}
