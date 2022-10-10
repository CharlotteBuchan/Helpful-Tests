using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = "";
            while (Input != "superman" & Input != "batman")
            {
                Console.Write("Enter your favourite Superhero: ");
                Input = Console.ReadLine().ToLower();
                if (Input != "superman" & Input != "batman")
                {
                    Console.WriteLine("Not a real superhero. Try again.");
                    Console.Clear();
                }
            }
            if (Input.ToLower() == "superman")
            {
                Console.WriteLine("You are lame.");
            }
            else
            {
                Console.WriteLine("You are cool.");
            }
        }
    }
}