using System;

namespace izpit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Цената на багаж над 20кг - реално число в диапазона[10.0…80.0]
            //Килограми на багажа – реално число в диапазона[1.0…32.0]
            //Дни до пътуването – цяло число в диапазона[1…60]
            //Брой багажи – цяло число в диапазона[1…10]

            double cenatabagajnad20 = double.Parse(Console.ReadLine());
            double kgBagaj = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numBagaji = int.Parse(Console.ReadLine());

            double resultkg = 0;
            if(kgBagaj < 10)
            {
                resultkg = cenatabagajnad20 * 0.80;
            }
            else if(kgBagaj >= 10 && kgBagaj <= 20)
            {
                resultkg = cenatabagajnad20 * 0.50;
            }
            else if(kgBagaj > 20)
            {
                resultkg = cenatabagajnad20;
            }

            if(days > 30)
            {
                resultkg = resultkg + (resultkg * 0.10);
            }
            else if(days >= 7 && days <= 30 )
            {
                resultkg = resultkg + (resultkg * 0.15);
            }
            else if(days < 7)
            {
                resultkg = resultkg + (resultkg * 0.40);
            }
            resultkg *= numBagaji;

            Console.WriteLine($"The total price of bags is: {resultkg} lv. ");
        }

    }
}
