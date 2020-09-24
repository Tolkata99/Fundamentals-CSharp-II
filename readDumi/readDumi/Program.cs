using System;

namespace readDumi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                string output = Console.ReadLine();

                if(output == "Stop")
                {
                    break;
                }
                Console.WriteLine(output);
            }
            
        }
    }
}
