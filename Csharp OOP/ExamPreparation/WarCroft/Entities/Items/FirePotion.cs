using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private static int firePotionWeight = 5;
        public FirePotion() : base(firePotionWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if(character.IsAlive)
            {
                character.Health -= 20;
                if(character.Health<=0)
                {
                    character.IsAlive = false;
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }
    }
}
