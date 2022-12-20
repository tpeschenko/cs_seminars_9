using System;

namespace Project
{
    class Program
    {
        static void Main(string[] agrs)
        {
            void Task69()
            {
                // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
                // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

                // M = 1; N = 9. -> "3, 6, 9"
                // M = 13; N = 20. -> "15, 18"
                PrintNumbers();


                void PrintNumbers(int M = 1, int N = 27)
                {
                    if(M % 3 == 0) Console.Write($"{M}  ");
                    
                    if(M >= N) return;
                    M++;
                    PrintNumbers(M, N);

                }
                
                
            }

            Task69();
        }   
    }
}












// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
// который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

