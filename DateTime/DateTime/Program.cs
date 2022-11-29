using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date: (dd/mm/yyyy) ");
            DateTime value = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(value.ToString("yyyy"));
        }
    }
}