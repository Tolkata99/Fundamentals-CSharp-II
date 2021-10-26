using System;

namespace izpit
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string nameAvioCompany = Console.ReadLine();
            int numTicketOld = int.Parse(Console.ReadLine());
            int numTicketYoung = int.Parse(Console.ReadLine());

            double netnaCenaBilet = double.Parse(Console.ReadLine());
            double cenaTaksa = double.Parse(Console.ReadLine());


            double priseOld = netnaCenaBilet;
            double PriseKid = netnaCenaBilet *= 0.30 ;
            

            priseOld += cenaTaksa;
            PriseKid += cenaTaksa;

            priseOld *= numTicketOld;
            PriseKid *= numTicketYoung;







            double result = priseOld + PriseKid;
            double eresult = result - (result * 0.80);


            Console.WriteLine($"The profit of your agency from {nameAvioCompany} tickets is {eresult:f2} lv.");
        }
    }
}
