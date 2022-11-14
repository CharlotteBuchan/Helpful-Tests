using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_3
{
    public class Game
    {
        public void StartFunction()
        {
            Console.WriteLine("Game started.");

            Character Player = new Character("Player", 3, true);
            Character Enemy = new Character("Enemy", 3, false);

            Player.Attack(Enemy);

            Enemy.Attack(Player);
        }
    }
}