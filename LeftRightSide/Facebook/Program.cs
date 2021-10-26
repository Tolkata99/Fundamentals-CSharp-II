using System;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double zaplata = double.Parse(Console.ReadLine());
            double result = 0.00;

            for (int i = 0; i <= n; i++)
            {
                string site = Console.ReadLine();

                if(site == "Facebook")
                {
                     result = zaplata - 150;
                }
                if(site == "Instagram")
                {
                    result = zaplata - 100;
                }
                if(site == "Reddit")
                {
                    result = zaplata - 50;
                }
                if (result <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }



            }
           
            if (zaplata > 0)
            {
                Console.WriteLine(result);
            }





        }
    }
}
