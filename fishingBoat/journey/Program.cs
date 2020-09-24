
            using System;

namespace pochivka
{ 
    {
        class Program
        {
            static void Main(string[] args)
            {
                double butget = double.Parse(Console.ReadLine());
                string season = Console.ReadLine();

                double butgetPrise = 0;
                string destinaciq = string.Empty;
                string spane = string.Empty;

                if (butget <= 100)
                {
                    destinaciq = "Bulgaria";

                    if (season == "summer")
                    {   
                        butgetPrise = butget * 0.30;
                        
                    }
                    else if(season == "winter")
                    {
                        butgetPrise *= 0.70;
                        
                    }
                }
                else if(butget <= 1000)
                {
                    destinaciq = "Balkans";

                        if (season == "summer")
                        {
                            butgetPrise = butget * 0.40;
                           
                        }
                        else if (season == "winter")
                        {
                            butgetPrise *= 0.80;
                            
                        }
                }
                else if (butget > 1000)
                {
                    destinaciq = "Europe";

                    if (season == "summer")
                    {
                        butgetPrise = butget * 0.90;
                        
                    }
                    else if (season == "winter")
                    {
                        butgetPrise *= 0.90;
                       
                    }
                }

                if(destinaciq == "Europe")
                {
                    spane = "Hotel";
                }
                else if(season == "summer")
                {
                    spane = "Camp";
                }
                else
                {
                    spane = "Hotel";
                }


                //⦁	Първи ред – „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe”
                  //⦁	Втори ред – “{ Вид почивка} – { Похарчена сума}“


                Console.WriteLine($"Somewhere in {destinaciq} ");
                Console.WriteLine($"{spane} – {butgetPrise:f2}");
            }
        }
    }
}
    