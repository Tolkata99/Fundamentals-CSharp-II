using System;
using System.Text.Json.Serialization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbroitopki = int.Parse(Console.ReadLine());

            int redcount = 0;
            int orangecount = 0;
            int yeslowcount = 0;
            int whitecount = 0;
            int blackcount = 0;

            int balsFalse = 0;

            int score = 0;
            for (int i = 1; i <= nbroitopki; i++)
            {
                string colorBals = Console.ReadLine();

                if(colorBals == "red" )
                {
                    score += 5;
                    redcount++;
                }
                else if (colorBals == "orange")
                {
                    score += 10;
                    orangecount++;
                }
                else if (colorBals == "yellow")
                {
                    score += 15;
                    yeslowcount++;
                }
                else if (colorBals == "white")
                {
                    score += 20;
                    whitecount++;
                }
                else if (colorBals == "black")
                {
                    score /= 2;
                    blackcount++;
                }
                else
                {
                    balsFalse++;
                }
            }
             Console.WriteLine($"Total points: {score}");
             Console.WriteLine($"Points from red balls: {redcount}");
             Console.WriteLine($"Points from orange balls: {orangecount}");
             Console.WriteLine($" Points from yellow balls: {yeslowcount}");
             Console.WriteLine($" Points from white balls: {whitecount}");
             Console.WriteLine($"Other colors picked: {balsFalse}");
             Console.WriteLine($"Divides from black balls: {blackcount}");

           

        }
    }
}
