using System;


namespace cizcpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int n1 = number1 / 1000;// 1 вото число 
            int n2 = number1 / 100 % 10; //2 рото число
                    
            int n3 = number1 / 10 % 10;//3тото число
            int n4 = number1 % 10;//4тото число


            int num1 = number2 / 1000;
            int num2 = number2 / 100 % 10;

            int num3 = number2 / 10 % 10;
            int num4 = number2 % 10;

            for (int x1 = 1; x1 <= 9; x1++)
            {
                for (int x2 = 1; x2 <= 9; x2++)
                {
                    for (int x3 = 1; x3 <= 9; x3++)
                    {
                        for (int x4 = 1; x4 <= 9; x4++)
                        {

                            if ((x1 % 2 != 0 || x1 == 1) && x1 >= n1 && x1 <= num1)
                            {
                                if ((x2 % 2 != 0 || x2 == 1) && x2 >= n2 && x2 <= num2)

                                {
                                    if ((x3 % 2 != 0 || x3 == 1) && x3 >= n3 && x3 <= num3)

                                    {
                                        if ((x4 % 2 != 0 || x4 == 1) && x4 >= n4 && x4 <= num4)

                                            Console.Write($"{x1}{x2}{x3}{x4} ");

                                    }

                                }

                            }

                        }
                    }

                }
            }
        }
    }
}

