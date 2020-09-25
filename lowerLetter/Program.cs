using System;

namespace lowerLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            bool isResult;

            isResult = Char.IsUpper(letter);

            isResult = Char.IsLower(letter);

            if(isResult)
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
               
            }    


        }
    }
}
