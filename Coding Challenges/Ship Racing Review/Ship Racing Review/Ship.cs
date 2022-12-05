using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ship_Racing_Review
{
    internal class Ship
    {
        public int movementSpeed = System.Security.Cryptography.RandomNumberGenerator.GetInt32(1, 4);
        public int currentPosition;
        internal string name;

        internal void Move()
        {
            currentPosition = currentPosition + movementSpeed;
            Console.WriteLine($"{name} is currently at {currentPosition} space units away from start.");
        }

        internal bool HasWon()
        {
            if (currentPosition < 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        internal bool Slow()
        {
            if (currentPosition > 50)
            {
                this.movementSpeed = this.movementSpeed - 1;
                Console.WriteLine("Stellar has been slowed by Astro's ability.");
                return true;
            }
            else
            {
                return false;
            }
        }

        /*internal bool Swap()
        {

        }*/
    }
}
