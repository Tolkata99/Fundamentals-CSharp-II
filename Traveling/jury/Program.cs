using System;

namespace jury
{
    class Program
    {
        static void Main(string[] args)
        {
            double always = 0;
            int presentations = 0;

            int juryNum = int.Parse(Console.ReadLine());
            while (true)
            {
                double obshtUspeh = 0;
               

                string output = Console.ReadLine();//name presentations
                if(output == "Finish")
                {
                    break;
                }
                
                presentations++;
                
                for (int i = 0; i < juryNum; i++)
                {
                    double NumberGrade = Double.Parse(Console.ReadLine());
                    obshtUspeh += NumberGrade;

                    
                }
                obshtUspeh /= juryNum;
                Console.WriteLine($"{output} - {obshtUspeh:f2}.");

                always += obshtUspeh;

                
                    

                
                

            }
            always /= presentations;
            
            Console.WriteLine($"Student's final assessment is {always:f2}.");






        }
    }
}
