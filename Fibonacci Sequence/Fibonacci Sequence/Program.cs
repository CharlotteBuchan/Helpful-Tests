using System;

namespace Fibonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Fibonacci(num1, num2);
        }

        static void Fibonacci(int num, int previousNum)
        {
            int holder;
            int i = 0;
            while (i <= 50)
            {
                Console.WriteLine(num);
                holder = num;
                num = num + previousNum;
                previousNum = holder;
                i += 1;
            }
        }
    }
}