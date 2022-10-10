using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Num3;
            Console.Write("Enter your first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Num3 = (Num1 + Num2);
            Console.WriteLine($"Your final number is {Num3}");
        }
    }
}