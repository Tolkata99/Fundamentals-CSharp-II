using System;

namespace dd
{
    class Program
    {
        static void Main(string[] args)
        {
            double Number = double.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;

            double EvenMin = double.MaxValue;
            double EvenSum = 0;
            double EvenMax = double.MinValue;

            if (Number == 0)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            

            for (int i = 1; i <= Number; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (Number == 1)
                {
                    Console.WriteLine($"OddSum={num:f2},");
                    Console.WriteLine($"OddMin={num:f2}, ");
                    Console.WriteLine($"OddMax={num:f2},");
                    Console.WriteLine("EvenSum=0.00,");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                if (i % 2 == 0)
                {
                    EvenSum += num;

                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }
                    if (num < EvenMin)
                    {
                        EvenMin = num;
                    }

                }
                else
                {
                    OddSum += num;

                    if(num > OddMax)
                    {
                        OddMax = num;
                    }
                    if(num < OddMin)
                    {
                        OddMin = num;
                    }

                }
                


            }
            if(Number > 1)
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
