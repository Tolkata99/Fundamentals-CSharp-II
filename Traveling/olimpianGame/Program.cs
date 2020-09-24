using System;

namespace olimpianGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numDays; i++)
            
            {
                string sports = Console.ReadLine();
                
                double winGame = 0;
                double loseGame = 0;
                double winGamee = 0;

                while (true)
                {
                    string winAndLose = Console.ReadLine();
                    if (winAndLose == "Finish")
                    {
                        break;
                    }


                    if (winAndLose == "win")
                    {
                        winGame ++; ;

                     
                    }
                     else if(winAndLose == "lose")
                     {
                         loseGame++;
                     }
                    
                     
                     
                }
                if (loseGame == 0)
                {
                    winGame *= 20;
                    winGame *= 1.10;
                    
                }
                if(winGame > loseGame)
                {
                    winGamee *= 20;
                    winGamee *= 1.10;
                   
                }
                else
                {
                    winGame *= 20;
                    winGame *= 1.10;
                }

                if (winGame > loseGame)
                {
                   
                    
                    Console.WriteLine(winGame + winGamee);

                }
                else
                {
                    
                    Console.WriteLine(winGame + winGamee);
                }
                
            }
            

            
            
            
        }
    }
}
