using System;

namespace solutions_paro
{
    class Program
    {
        static void Main(string[] args)
        {
           

                int bitcoin = int.Parse(Console.ReadLine());
            double kitaiioan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double priseBitcoin = bitcoin * 1168;//bgn
            double prieKitaiOan = kitaiioan * 0.15;//usd
            double priseKitaiBgn = prieKitaiOan * 1.76;

            double comisione = comision / 100;
            double result = priseBitcoin + priseKitaiBgn;
            double result1 = result - (result * comisione);
            result1 /= 1.95;

            Console.WriteLine($"{result1:f3}");






        }
    }
}
