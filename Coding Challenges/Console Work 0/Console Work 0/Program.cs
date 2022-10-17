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
            switch (Attack)
            {
                case 'Q':
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
                    break;
                case 'E':
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
                    break;

                case 'R':
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
                    break;
                case 'Z':
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
                    break;
                case 'X':
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
                    break;
                default:
                    Console.WriteLine("Oh no! That is an incorrect key!");
                    Main(null);
                    break;
            }
        }
    }
}