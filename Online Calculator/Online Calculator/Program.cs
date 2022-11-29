using System;

namespace OnlineCalculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            Console.WriteLine("Enter your first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            bool again = true;
            while (again == true)
            {
                Console.WriteLine("Choose what you would like to do:");
                Console.WriteLine(" +\n -\n x\n /");
                string symbolPick = Console.ReadLine();
                switch (symbolPick)
                {
                    case "+":
                        again = false;
                        thirdNumber = firstNumber + secondNumber;
                        Console.WriteLine($"Your third number is {thirdNumber}");
                        break;
                    case "-":
                        again = false;
                        thirdNumber = firstNumber - secondNumber;
                        Console.WriteLine($"Your third number is {thirdNumber}");
                        break;
                    case "x":
                        again = false;
                        thirdNumber = firstNumber * secondNumber;
                        Console.WriteLine($"Your third number is {thirdNumber}");
                        break;
                    case "/":
                        again = false;
                        thirdNumber = firstNumber / secondNumber;
                        Console.WriteLine($"Your third number is {thirdNumber}");
                        break;
                    default:
                        again = true;
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}