using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = string.Empty;
           

            for (int i = name.Length - 1; i >= 0; i--)
            {
                password += name[i];
            }
            int counter = 0;
            while (true)
            {
                string pasword1 = Console.ReadLine();
                if (password == pasword1)
                {

                    Console.WriteLine($"User {name} logged in.");
                    break;
                }
                else
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {name} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }

            }

        }
    }
}
