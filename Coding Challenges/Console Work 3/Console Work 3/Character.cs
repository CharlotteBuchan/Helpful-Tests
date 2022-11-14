using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Work_3
{
    class Character
    {
        public string characterName;
        public int maxHP;
        public bool isPlayer;

        public Character(string _characterName, int _maxHP, bool _isPlayer)
        {
            characterName = _characterName;
            maxHP = _maxHP;
            isPlayer = _isPlayer;
        }

        public void Attack(Character BeingAttacked)
        {
            BeingAttacked.maxHP -= 1;
            Console.WriteLine($"{BeingAttacked.characterName} took 1 damage, and is now at {BeingAttacked.maxHP} HP.");
        }
    }
}