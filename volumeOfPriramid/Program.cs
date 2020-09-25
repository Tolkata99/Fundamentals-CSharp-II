using System;

namespace volumeOfPriramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double dul = 0;
            double sh = 0;
            double V = 0;


            Console.Write("Length: ");
            dul = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            sh = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            V = double.Parse(Console.ReadLine());

            V = (dul * sh * V) / 3;

            Console.WriteLine($"Pyramid Volume: {V:f2}");
            

        }
    }
}
