using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    internal class Priest : Character, IHealer
    {
        private static Backpack backpack = new Backpack();
        public Priest(string name) : base(name, 50, 25, 40, backpack)
        {
            base.BaseHealth = 50;
            base.BaseArmor = 25;
        }

        public void Heal(Character character)
        {
            if(character.IsAlive&&this.IsAlive)
            {
                character.Health += 40;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }
    }
}
