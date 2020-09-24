using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ддд
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxnumer = int.MinValue;
            int minnumer = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int sum = int.Parse(Console.ReadLine());

                if (sum > maxnumer)
                {
                    maxnumer = sum;
                    
                }
                if(sum < minnumer)
                {
                    minnumer = sum;
                    
                }
                Console.WriteLine("Max number" + maxnumer);
                Console.WriteLine("Min number" + minnumer);
            }   

        }

    }
}    
    
