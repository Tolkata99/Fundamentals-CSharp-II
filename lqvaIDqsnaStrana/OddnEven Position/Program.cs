using System;

namespace OddnEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double OddSum = 0.00;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;

            double EvenSum = 0.00;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

                if(n == 0)
                {

                 Console.WriteLine("OddSum=0.00,");
                 Console.WriteLine("OddMin=No,");
                 Console.WriteLine("OddMax=No,");
                 Console.WriteLine("EvenSum=0.00,");
                 Console.WriteLine("EvenMin=No,");
                 Console.WriteLine("EvenMax=No");

                }

            for (int i = 1; i <= n; i++)
            {
                double sum = double.Parse(Console.ReadLine());
                if(n == 1)
                {
                    Console.WriteLine($"OddSum={OddSum:f2},");
                    Console.WriteLine($"OddMin={OddMin:f2},");
                    Console.WriteLine($"OddMax={OddMax:f2},");
                    Console.WriteLine($"EvenSum=0.00,");
                    Console.WriteLine($"EvenMin=No,");
                    Console.WriteLine($"EvenMax=No");

                }

                if(i % 2 == 1)
                {
                    OddSum += sum;

                    if(sum > OddMax)
                    {
                        OddMax = sum;
                    }

                    if(sum < OddMin)
                    {
                        OddMin = sum;
                    }
                }
                else
                {
                    EvenSum += sum;

                    if(sum > EvenMax)
                    {
                        EvenMax = sum;
                    }
                    if(sum < EvenMin)
                    {
                        EvenMin = sum;
                    }

                    
                }
                
            }
            if (n > 1)
            {
                Console.WriteLine($"OddSum={OddSum:f2},");
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
                Console.WriteLine($"EvenSum={EvenSum:f2},");
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");

            }

        }
    }
}
