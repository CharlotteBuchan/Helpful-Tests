using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Ship_Racing_Review
{
    internal class Game
    {
        StellarShip stellarShip = new StellarShip("Stellar");
        AstroShip astroShip = new AstroShip("Astro");
        public void GameLoop()
        {

            bool stellarWon = stellarShip.HasWon();
            bool astroWon = astroShip.HasWon();
            bool astroAbility = stellarShip.Slow();

            while (!stellarWon && !astroWon)
            {
                stellarShip.Move();
                astroShip.Move();

                stellarWon = stellarShip.HasWon();
                astroWon = astroShip.HasWon();
            }

            if (stellarWon && astroWon)
            {
                Console.WriteLine("Draw");
            }
            else if (stellarWon)
            {
                if (astroWon)
                {
                    Console.WriteLine($"Astro Ship is the winner, moving at {astroShip.movementSpeed} speed.");
                }
                else
                {
                    Console.WriteLine($"Stellar Ship is the winner, moving at {stellarShip.movementSpeed} speed.");
                }
            }
        }
        /*public void SwapPlaces()
        {
            Console.WriteLine("Stellar has used it's ability to swap places with Astro.");
            
        }*/
    }
}
