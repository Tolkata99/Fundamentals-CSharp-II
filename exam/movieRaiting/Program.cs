using System;

namespace movieRaiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMovie = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            double min = double.MaxValue;
            double totalRating = 0;
            string nameBigRating = string.Empty;
            string nameLowestRating = string.Empty;
            for (int i = 1; i <= numMovie; i++)
            {
                string nameMovie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if(max < rating)
                {
                    max = rating;
                    nameBigRating = nameMovie;
                }
                if(min > rating)
                {
                    min = rating;
                    nameLowestRating = nameMovie;
                }

                totalRating += rating;



            }

            double average = totalRating / numMovie;

            Console.WriteLine($"{nameBigRating} is with highest rating: {max:f1}");
            Console.WriteLine($"{nameLowestRating} is with lowest rating: {min:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
