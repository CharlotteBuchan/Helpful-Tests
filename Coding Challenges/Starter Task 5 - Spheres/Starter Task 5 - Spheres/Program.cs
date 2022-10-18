using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535897931;
            Console.Write("Enter the radius of your sphere: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = (radius * radius * PI * 4);
            double volume = (radius * radius * radius * PI * 4/3);
            Console.WriteLine($"The surface area of your sphere is {area}, and the volume is {volume}");
        }
    }
}