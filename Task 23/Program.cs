using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для которого необходимо вычислить факториал");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            Console.ReadKey();
        }
        static void Fact(int n)
        {
            int factorial = 1;  
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Факториал числа числа " + n + " равен " + factorial);
        }

        static async void FactAsync(int n)
        {
            await Task.Run(()=>Fact(n));
        }
    }
}
