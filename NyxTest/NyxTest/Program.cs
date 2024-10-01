using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optionsAnswered = 0;
            int optionPicked;

            do
            {
                Console.WriteLine("All 3 options: 1. ... 2. ... 3. ...");
                optionPicked = Convert.ToInt32(Console.ReadLine());
                if (optionPicked == 1)
                {
                    Console.WriteLine("Answer to 1");
                    optionsAnswered++;
                }
                else if (optionPicked == 2)
                {
                    Console.WriteLine("Answer to 2");
                    optionsAnswered++;
                }
                else if (optionPicked == 3)
                {
                    Console.WriteLine("No answer");
                    break;
                }
                else if (optionPicked > 3)
                {
                    Console.WriteLine("Incorrect Option");
                }
            }
            while (optionPicked != 3);
        }
    }
}