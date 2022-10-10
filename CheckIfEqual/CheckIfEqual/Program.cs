using System;
using System.Runtime.ExceptionServices;

namespace CheckIfEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;
            bool Equal;

            Console.Write("Enter first number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            Equal = (FirstNumber == SecondNumber);

            if (Equal == true)
            {
                Console.WriteLine("The numbers are the same");
            }
            else
            {
                Console.WriteLine("The numbers are not the same");
            }
        }
    }
}