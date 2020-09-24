using System;

namespace operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	N1 – цяло число в интервала [0...40 000]  
            //N2 – цяло число в интервала[0...40 000]
            //	Оператор – един символ измежду: „+“, „-“, „*“, „/“, „%“


            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            //Напишете програма, която чете две цели числа (N1 и N2) и оператор, с койт
            //* о да се извърши дадена математическа операция с тях. Възможните операции са: 
            // * Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). 
            // * При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.
            // * При обикновеното деление – резултата. При модулното деление – остатъка.
            // * Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели.
            //* В този случай трябва да се отпечата специално съобщениe./*
            string output = string.Empty;
            double result = 0;
            string evenOrodd = " ";
            if(N2  == 0)
            {
                  output = $"Cannot divide {N1} by zero";

            }
            else if(operation == "+")
            {
                result = N1 + N2;
                

                output = $"{N1} {operation} {N2} = {result} - ";
            }
            else if (operation == "-")
            {
                result = N1 - N2;
                

                output = $"{N1} {operation} {N2} = {result} - ";
            }
            else if (operation == "*")
            {
                result = N1 * N2;
                
                output = $"{N1} {operation} {N2} = {result} - ";

            }
            else if (operation == "/")
            {
                result = (N1 * 1.0) / N2;

                output = $"{N1} / {N2} = {result:f2}";  //– резултатът е форматиран до вторият знак след дес.запетая

            }
            else if (operation == "%")
            {
                result = N1 % N2;

                output = $"{N1} % {N2} = {result}";

            }

            if(operation == "+"|| operation == "-" || operation == "*")
            {
                if (result % 2 == 0)
                {
                    evenOrodd = "even";
                }
                else
                {
                    evenOrodd = "odd";
                }
                output += evenOrodd;
            }

            Console.WriteLine(output);


        }   
    }        
}
