using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Invalids = 0;
            List<string> Names = new List<string>()
            {
                "Biff", "Chip", "Kipper", "Hans", "Super"
            };

            foreach (string name in Names)
            {
                if (name.Length == 4)
                {
                    Console.WriteLine($"{name}");
                }
                else
                {
                    Console.WriteLine($"{name} is invalid");
                    Invalids = Invalids + 1;
                }
            }
            Console.WriteLine($"{Invalids} invalids.");
        }
    }
}