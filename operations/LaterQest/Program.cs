using System;

namespace LaterQest
{
    class Program
    {
        static void Main(string[] args)
        {
            ///⦁	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            ///⦁	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            /////⦁	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            //////⦁	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59

            int chasIzpit = int.Parse(Console.ReadLine());
            int minutaIzpit = int.Parse(Console.ReadLine());
            int chasPristigane = int.Parse(Console.ReadLine());
            int minutaPristigane = int.Parse(Console.ReadLine());

            int MinutiChasIzpit = (chasIzpit * 60) + minutaIzpit;
            int pristiganeMin = (chasPristigane * 60) + minutaPristigane;


            if ( pristiganeMin > MinutiChasIzpit )
            {
                Console.WriteLine("Late");
                int late = pristiganeMin - MinutiChasIzpit;
                if(late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int latechas = late / 60;
                    int lateMinuti = late % 60;
                    Console.WriteLine($"{latechas}:{lateMinuti:D2} hours after the start");
                }
            }
            else if (MinutiChasIzpit == pristiganeMin || MinutiChasIzpit - pristiganeMin <= 30)
            {
                Console.WriteLine("On time");
                if(MinutiChasIzpit - pristiganeMin <=30)
                {
                    Console.WriteLine($"{MinutiChasIzpit - pristiganeMin} minutes before the start");
                }
            }
            else if (MinutiChasIzpit - pristiganeMin > 30)
            {
                Console.WriteLine("Early");
                int early = MinutiChasIzpit - pristiganeMin;
                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
                else
                {
                    int earlychas = early / 60;
                    int earlyminutes = early % 60;
                    
                    Console.WriteLine($"{earlychas}:{earlyminutes:D2} hours before the start");
                }


            }
            




        }
    }
}
