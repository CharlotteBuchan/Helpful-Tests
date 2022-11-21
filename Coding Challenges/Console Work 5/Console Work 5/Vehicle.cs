using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_5
{
    public class Vehicle
    {
        public int Speed;

        public void Move()
        {
            Console.WriteLine($"The vehicle is moving at {Speed} kmph.");
        }
    }
}
