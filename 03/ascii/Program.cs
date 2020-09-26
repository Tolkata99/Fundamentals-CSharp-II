using System;

namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());


            for (int i = n; i <= n1; i++)
            {
                char s = ((char)i);
                Console.Write(s);
            }

        }
    }
}
