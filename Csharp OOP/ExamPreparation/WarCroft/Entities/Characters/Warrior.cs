using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private static Satchel satchel = new Satchel();
        public Warrior(string name) : base(name, 100,
            50, 40, satchel)
        {
            base.BaseHealth = 100;
            base.BaseArmor = 50;
        }

        public void Attack(Character character)
        {
            if(character.IsAlive&&this.IsAlive)
            {
                if(this==character)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                character.TakeDamage(40);
            }
            else
                {
                    throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
                }
            
        }
    }
}
