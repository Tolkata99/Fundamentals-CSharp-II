using System;

namespace sumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int suma = 0;
            for (int i = 0; i <= 10; i++)
            {
                int CurentNumber = int.Parse(Console.ReadLine());
                suma += CurentNumber;

                if(suma >= CurentNumber)
                {
                    break;
                }
                Console.WriteLine(suma);
            }


            
        }
    }
}
