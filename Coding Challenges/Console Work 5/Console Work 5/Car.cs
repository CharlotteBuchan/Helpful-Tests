using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Console_Work_5
{
    public class Car : Vehicle
    {
        public int numberOfSeats;

        public Car()
        {
            Speed = 180;
        }

        public void StorieItemsInBoot()
        {
            Console.WriteLine("Items stored.");
        }
    }
}
