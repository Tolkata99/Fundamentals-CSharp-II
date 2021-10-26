using System;
using System.Diagnostics.CodeAnalysis;

namespace lqvaIDqsnaStrana
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberlqvo = 0;
            int numberdqsno = 0;
            for (int i = 1; i < n; i++)
            {
                int CurrentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    numberlqvo += CurrentNumber ;
                }
                else
                {
                    numberdqsno +=CurrentNumber ;
                }

                
                
            }
            if (numberdqsno == numberlqvo)
            {
                
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + numberlqvo);
            }
            else
            {
                int difeerce = numberdqsno - numberlqvo;
                Console.WriteLine("Yes");
                Console.WriteLine("Diff = " + Math.Abs(difeerce));
            }
        }
    }
}
