using System;

namespace mobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Срок на договор – текст – "one", или "two"
            //Тип на договор – текст – "Small",  "Middle", "Large"или "ExtraLarge"
            //Добавен мобилен интернет – текст – "yes" или "no"
            //Брой месеци за плащане

            string dogovor = Console.ReadLine();
            string tipDogovor = Console.ReadLine();
            string dobavenMobNet = Console.ReadLine();
            int month = int.Parse(Console.ReadLine());

            double prise = 0;

            if(dogovor == "two")
            {
                if (tipDogovor == "Small")
                {
                    prise += 8.58;
                }
                else if (tipDogovor == "Middle")
                {
                    prise += 17.09;
                }
                else if (tipDogovor == "Large")
                {
                    prise += 23.59;
                }
                else if (tipDogovor == "ExtraLarge")
                {
                    prise += 31.79;
                }

                
            }
            else if (dogovor == "one")
            {
                if(tipDogovor == "Small")
                {
                    prise += 9.98;
                }
                if (tipDogovor == "Middle")
                {
                    prise += 18.99;
                }
                if (tipDogovor == "Large")
                {
                    prise += 25.98;
                }
                if (tipDogovor == "ExtraLarge")
                {
                    prise += 35.99;
                }
            }

            if(dobavenMobNet == "yes")
            {
                if(prise <= 10)
                {
                    prise += 5.50;
                }
                else if(prise <= 30 && prise >= 10.01)
                {
                    prise += 4.35;
                }
                else if(prise >= 30)
                {
                    prise += 3.85;
                }
               ;
            }
            
            
            prise *= month ;
            if (dogovor == "two")
                prise *= 0.9625;
            Console.WriteLine($"{prise:F2} lv.");



        }
    }
}
