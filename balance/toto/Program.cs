using System;

namespace toto
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());

            double razmertorta = duljina * shirochina;
            string comand = Console.ReadLine();
            
            while (comand != "STOP")
            {
                int parchetatorta = int.Parse(comand);
                razmertorta -= parchetatorta;
                
                if(razmertorta <= 0)
                {
                    break;
                }


                comand = (Console.ReadLine());
            }
            string result = string.Empty;
            if(razmertorta > 0)
            {
                result = $"{razmertorta} pieces are left";
            }
            else
            {
                result = $"No more cake left! You need {Math.Abs(razmertorta)} pieces more.";
            }
            Console.WriteLine((result));
        }
    }
}
