using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159265359;

            Console.Write("Enter the radius of your sphere: ");
            double radius = Convert.ToInt32(Console.Read());
            Volume(radius, pi);
            SurfaceArea(radius, pi);
            
        }

        static void Volume(double r, double pi)
        {
            double volume = (4 / 3) * pi * r;
            Console.WriteLine("The volume of your sphere is " + volume);
        }

        static void SurfaceArea(double r, double pi)
        {
            double surfaceArea = 4 * pi * (r * r);
            Console.WriteLine("The surface area of your sphere is " + surfaceArea);
        }
    }
}