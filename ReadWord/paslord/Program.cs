using System;

namespace paslord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            while (suma < n)
            {
                int CurentNumber = int.Parse(Console.ReadLine());
                suma += CurentNumber;
            }
            Console.WriteLine(suma);
            
        }
    }
}
