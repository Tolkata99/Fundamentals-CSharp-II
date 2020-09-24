using System;

namespace Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
           /// */⦁	Възрастта на Лили - цяло число в интервала[1...77]
          //  Цената на пералнята – реално число
	      //   Цена на играчки – реално число
            int vuzrastLilly = int.Parse(Console.ReadLine());
            double cenaPeralnq = double.Parse(Console.ReadLine());
            double cenaIgrachki = double.Parse(Console.ReadLine());

            int igrachki = 0;
            double pari = 0.00;
           
            for (int i = 1; i <= vuzrastLilly; i++)
            {
                if(i % 2 == 0)
                {
                    pari += i * 5;
                    pari--;
                }
                else
                {
                    igrachki++;
                }

            }
            double Priseigrachki = cenaIgrachki * igrachki;
            pari += Priseigrachki;

            if(pari >= cenaPeralnq)
            {
                double N = pari - cenaPeralnq;
                Console.WriteLine($"Yes! {N:f2}");
            }
            else
            {
                double M = cenaPeralnq - pari;
                Console.WriteLine($"No! {M:f2}");
            }
        }
    }
}
