using Ship_Racing_Review;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Ship_Racing_Review
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameLoop();
        }
    }
}