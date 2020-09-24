using System;

namespace prot
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
                int movieTicketSold = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if(ticketType == "End")
                    {
                        break;
                    }
                    

                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if(ticketType == "standard")
                    {
                        standard++;
                    }
                    else if(ticketType == "kid")
                    {
                        kid++;
                    }
                    movieTicketSold++;
                   

                    if (movieTicketSold == freePlases)
                    {
                        break;
                    }

                    
                }
                double result = (movieTicketSold * 1.0) / freePlases * 100;
               
                Console.WriteLine($"{movieName} - {result:f2}% full.");
                


                
            }
            double soldTicket = kid + standard + student;

            double sumStudent = (student * 1.0) / soldTicket * 100 ;
            double sumStandart = (standard * 1.0) / soldTicket * 100 ;
            double sumKids = (kid * 1.0) / soldTicket * 100 ;
            Console.WriteLine($"Total tickets: {soldTicket}");
            Console.WriteLine($"{sumStudent:f2}% student tickets.");
            Console.WriteLine($"{sumStandart:f2}% standard tickets.");
            Console.WriteLine($"{sumKids:f2}% kids tickets.");



        }
    }
}
