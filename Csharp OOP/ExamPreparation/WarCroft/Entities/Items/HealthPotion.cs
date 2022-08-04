using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion : Item
    {
        private static int healthPotionWeight = 5;
        public HealthPotion() : base(healthPotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if(character.IsAlive)
            {
                character.Health += 20;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }


    }
}
