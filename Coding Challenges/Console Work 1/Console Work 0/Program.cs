using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int Num1;
        static int Num2;
        static int Num3;
        static int Num4;
        static int Num5;
        static void Main(string[] args)
        {
            Num5 = Adding(Num1, Num2, Num3, Num4);
            bool even = Even(Num5);
            Console.WriteLine(even);
        }

        static int Adding(int Num1, int Num2, int Num3, int Num4)
        {
            Console.Write("Enter first number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            Num4 = Convert.ToInt32(Console.ReadLine());

            Num5 = Num1 + Num2 + Num3 + Num4;
            Console.WriteLine(Num5);
            return Num5;
        }

        static bool Even(int Number)
        {
            Console.WriteLine("Is the number even?");
            if (Number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}