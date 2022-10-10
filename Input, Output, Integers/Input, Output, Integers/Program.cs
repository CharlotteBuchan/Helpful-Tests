using System;

namespace MyApp
{
    internal class Program
    {
        static int MonsterHealth = 100;
        static void Main(string[] args)
        {
            Console.Write("Oh no! A monster has appeared! Quick, attack it!! (Q, E, X, C, R) ");
            string Input = Console.ReadLine();
            Attacks(Input);
        }

        static void Attacks(AttackInput)
        {
            switch (AttackInput.ToUpper())
            {
                case "Q":
                    Console.WriteLine
                    MonsterHealth = MonsterHealth - 15;
                    break;
                case "E":
                    break;
                case "X":
                    break;
                case "C":
                    break;
                case "R":
                    break;
            }
        }
    }
}