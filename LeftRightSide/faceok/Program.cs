﻿using System;

namespace faceok
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());

            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tab; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    salary -= 150;
                }
                if (site == "Instagram")
                {
                    salary -=  100;
                }
                if (site == "Reddit")
                {
                    salary -=  50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }


        }
    }
}
