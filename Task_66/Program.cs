using System;

namespace Project
{
    class Program
    {
        static void Main(string[] agrs)
        {
            void Task69()
            {
                //  Задайте значения M и N. Напишите рекурсивный метод, 
                // который найдёт сумму натуральных элементов в промежутке от M до N.

                // M = 1; N = 15 -> 120
                // M = 4; N = 8. -> 30
                int sum = 0;
                PrintNumbers();


                void PrintNumbers(int M = 1, int N = 5)
                {
                    if(M > N) return;
                    sum += M;
                    M++;
                    PrintNumbers(M, N);
                }

            Console.Write(sum);  
                 
                
            }

            Task69();
        }   
    }
}