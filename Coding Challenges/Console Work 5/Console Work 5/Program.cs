using Console_Work_5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorbike Bike = new Motorbike();
            Bike.Move();
            Car _Car = new Car();
            _Car.Move();
        }
    }
}