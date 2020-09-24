using System;

namespace solutions_paro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());

            n %= 10;
            n1 %= 10;
            
            for (int x1 = n ; x1 <= n1 ; x1++)
            {
                n /= 10;


                while (n > 0 && n1 > 0)
                {
                    int purvochislo = n % 10;
                    int vtoto = n % 10;
                    if(purvochislo % 2 == 1 && vtoto % 2 == 1)
                    {

                    }
                    n /= 10;
                    n1 /= 10;
                }


            }
        }
    }
}
