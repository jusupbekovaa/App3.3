using System;

namespace App3_3
{
    class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество значений: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 0 && a <= 60)
                {
                    Console.WriteLine($"Fibonacci[{a}]={Fibonacci(a)}");
                }

                else
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadKey();
        }
    }
}

