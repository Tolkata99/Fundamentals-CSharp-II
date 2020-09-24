using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            int standard = 0;
            int kid = 0;
            
            
            
            while (true)
            {
                string movieName = Console.ReadLine();
                
                if (movieName == "Finish")
                {
                    break;
                }
                 int freePlases = int.Parse(Console.ReadLine());

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if(ticketType == "End")
                    {
                        break;
                    }

                    if(ticketType == "student")
                    {
                        student++;
                    }
                    else if(ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    priseSellTicket++;
                    if(priseSellTicket == freePlases)
                    {
                        break;
                    }

                    

                   
                }
                double fullRoom = priseSellTicket * 1.0 / freePlases * 100;
                Console.WriteLine($"{movieName} - {fullRoom}% full.");
                
            }
            double totalTicket = kid + standard + student;
            Console.WriteLine($"Total tickets: {totalTicket}");

            double priseStudent = student * 1.0 / totalTicket * 100;
            Console.WriteLine($"{priseStudent}% student tickets.");

            double priseStandart = standard * 1.0 / totalTicket * 100;
            Console.WriteLine($"{priseStandart}% standard tickets.");

            double priseKid = kid * 1.0 / totalTicket * 100;
            Console.WriteLine($"{priseKid}% kids tickets.");

        }
    }
}
