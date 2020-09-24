using System;

namespace summerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string dayOfNight = Console.ReadLine();
            string Outfit = " ";
            string Shoes = " ";

            if (degrees >=  10 && degrees <= 18)
            {
                if(dayOfNight == "Morning") 
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if(dayOfNight == "Afternoon" || dayOfNight == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }

            }
            else if(degrees >= 18 && degrees <= 24)
            {
                if (dayOfNight == "Morning" || dayOfNight == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if(dayOfNight == "Afternoon")
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                
            }
            else if (degrees >= 25)
            {
                if (dayOfNight == "Morning" )
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else if (dayOfNight == "Evening")
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (dayOfNight == "Afternoon")
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
                
            }
            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");



        }
    }
}
