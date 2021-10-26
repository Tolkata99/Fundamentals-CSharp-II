using System;
using System.Xml;

namespace footballResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string One = Console.ReadLine();
            string two = Console.ReadLine();
            string tri = Console.ReadLine();

            int counterWon = 0;
            int counterLost = 0;
            int counterDrawn = 0;

            int left = int.Parse(One.Split(':')[0]);
            int right = int.Parse(One.Split(':')[1]);

            int left1 = int.Parse(two.Split(':')[0]);
            int right1 = int.Parse(two.Split(':')[1]);

            int left2 = int.Parse(tri.Split(':')[0]);
            int right2 = int.Parse(tri.Split(':')[1]);

            if(left > right)
            {
                counterWon++;
            }
            if(right == left)
            {
                counterDrawn++;
            }
            if(right > left)
            {
                counterLost++;
            }

            if (left1 > right1)
            {
                counterWon++;
            }
            if (right1 == left1)
            {
                counterDrawn++;
            }
            if (right1 > left1)
            {
                counterLost++;
            }

            if (left2 > right2)
            {
                counterWon++;
            }
            if (right2 == left2)
            {
                counterDrawn++;
            }
            if (right2 > left2)
            {
                counterLost++;
            }
            Console.WriteLine($"Team won {counterWon} games.");
            Console.WriteLine($"Team lost {counterLost} games.");
            Console.WriteLine($" Drawn games: {counterDrawn}");
        }

    }
}
