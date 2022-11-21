using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Console_Work_5
{
    public class Motorbike : Vehicle
    {
        public bool hasSideCarridge;

        public Motorbike()
        {
            Speed = 260;
        }

        public void Wheely()
        {
            Console.WriteLine("This is  not safe at all...");
        }
    }
}
