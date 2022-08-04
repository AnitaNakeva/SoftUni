using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
			this.BaseHealth = 100;
			this.BaseArmor = 100;
			this.Name = name;
			this.Health = health;
			this.Armor = armor;
			this.AbilityPoints = abilityPoints;
			this.Bag = bag;
			
        }

		private string name;
        public string Name 
		{
			get
            {
				return this.name;
            }
			set
            {
				if(String.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException("Name cannot be null or whitespace!");
                }
				this.name = value;
            }
		}

		private double baseHealth;

        public double BaseHealth 
		{ 
			get
            {
				return this.baseHealth;
            }
			set
            {
				this.baseHealth = value;
            }
		}

		private double health;

        public double Health
		{ 
			get
            {
				return this.health;
            }
			set
            {

				this.health = value;
				if (this.health > this.BaseHealth)
                {
					this.health = this.BaseHealth;
                }

				if(this.health<0)
                {
					this.health = 0;
					IsAlive = false;
                }
            }
		}

		private double baseArmor;

		public double BaseArmor
		{
			get
			{
				return this.baseArmor;
			}
			set
			{
				this.baseArmor = value;
			}
		}

		private double armor;

		public double Armor
		{
			get
			{
				return this.armor;
			}
			set
			{
				this.armor = value;
				if(this.armor<0)
                {
					this.armor = 0;
                }
			}
		}

		private double abilityPoints;

        public double AbilityPoints 
		{
			get
            {
				return this.abilityPoints;
            }
			set
            {
				this.abilityPoints = value;
            }
		}

		public Bag Bag { get; private set; }

        public bool IsAlive { get; set; } = true;

		public void TakeDamage(double hitPoints)
        {
			EnsureAlive();
				if (hitPoints > this.Armor)
                {
					double amountToTake = hitPoints - this.Armor;
					this.Armor = 0;
					this.Health -= amountToTake;
					if(this.Health<=0)
                    {
						this.Health = 0;
						this.IsAlive = false;
                    }
				}
				else
            {
				this.Armor -= hitPoints;
            }
            
        }

		public void UseItem(Item item)
        {
			EnsureAlive();
			item.AffectCharacter(this);
        }


		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}