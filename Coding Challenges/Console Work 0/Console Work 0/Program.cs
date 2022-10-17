using System;

namespace MyApp
{
    internal class Program
    {
        static int MonsterHealth = 100;
        static void Main(string[] args)
        {

            Console.Write("Oh no! There is a monster!! ATTACK IT!!! (Q, E, R, Z, X) ");
            char Attack = Convert.ToChar(Console.ReadLine());
            if (Attack == 'Q')
            {
                MonsterHealth = (MonsterHealth - 15);
                if (MonsterHealth > 0)
                {
                    Console.WriteLine($"The monster is at {MonsterHealth} health!");
                    Main(null);
                }
                else
                {
                    Console.WriteLine("You killed the monster! Lets goooooo!");
                }
            }
            else if (Attack == 'E')
            {
                MonsterHealth = (MonsterHealth - 12);
                if (MonsterHealth > 0)
                {
                    Console.WriteLine($"The monster is at {MonsterHealth} health!");
                    Main(null);
                }
                else
                {
                    Console.WriteLine("You killed the monster! Lets goooooo!");
                }
            }
            else if (Attack == 'R')
            {
                MonsterHealth = (MonsterHealth - 20);
                if (MonsterHealth > 0)
                {
                    Console.WriteLine($"The monster is at {MonsterHealth} health!");
                    Main(null);
                }
                else
                {
                    Console.WriteLine("You killed the monster! Lets goooooo!");
                }
            }
            else if (Attack == 'Z')
            {
                MonsterHealth = (MonsterHealth - 25);
                if (MonsterHealth > 0)
                {
                    Console.WriteLine($"The monster is at {MonsterHealth} health!");
                    Main(null);
                }
                else
                {
                    Console.WriteLine("You killed the monster! Lets goooooo!");
                }
            }
            else if (Attack == 'X')
            {
                MonsterHealth = (MonsterHealth - 35);
                if (MonsterHealth > 0)
                {
                    Console.WriteLine($"The monster is at {MonsterHealth} health!");
                    Main(null);
                }
                else
                {
                    Console.WriteLine("You killed the monster! Lets goooooo!");
                }
            }
        }
    }
}