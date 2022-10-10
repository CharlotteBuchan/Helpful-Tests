using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string superhero;
            Console.Write("Enter your superhero: ");
            superhero = Console.ReadLine().ToLower();
            switch (superhero)
            {
                case "superman":
                    Console.WriteLine("Flight, superhuman strength, x-ray vision, heat vision, cold breath, super-speed, enhanced hearing, and nigh-invulnerability.");
                    break;
                case "batman":
                    Console.WriteLine("Batman does not possess any superpowers. but he is cool B)");
                    break;
                case "wolerine":
                    Console.WriteLine("Superhuman strength and reflexes, enhanced senses and tracking abilities, and a special healing power that also slows his aging.");
                    break;
                case "antman":
                    Console.WriteLine("Ant-Man initially had the power to shrink himself (and other people and objects along with himself) to the size of an ant and return to normal. Over time, he has acquired the ability to change size at will.");
                    break;
                case "ironman":
                    Console.WriteLine("Iron Man possesses powered armor that gives him superhuman strength and durability, flight, and an array of weapons.");
                    break;
                default:
                    Console.WriteLine("Try again.");
                    Main(null);
                    break;
            }
        }
    }
}