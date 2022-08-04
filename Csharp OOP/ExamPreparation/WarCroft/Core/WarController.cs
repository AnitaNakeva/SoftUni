using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Item> itemPool;
		private List<Character> party;

        public WarController()
		{
			this.itemPool = new List<Item>();
			this.party = new List<Character>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];
			if (characterType != "Warrior" && characterType != "Priest")
            {
				throw new ArgumentException($"Invalid character type \"{characterType}\"!");
			}
			if (characterType == "Priest")
			{
				Priest priest = new Priest(name);
				party.Add(priest);
			}
			else
			{
				Warrior warrior = new Warrior(name);
				party.Add(warrior);
			}
			return $"{name} joined the party!";
		}

		public string AddItemToPool(string[] args)
		{
			string itemName = args[0];
			if (itemName != "FirePotion" && itemName != "HealthPotion")
			{
				throw new ArgumentException($"Invalid item \"{itemName}\"!");
			}
			if (itemName == "FirePotion")
			{
				FirePotion firePotion = new FirePotion();
				itemPool.Add(firePotion);
			}
			else
			{
				HealthPotion healthPotion = new HealthPotion();
				itemPool.Add(healthPotion);
			}

			return $"{itemName} added to the pool.";
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];
			var charToPick = this.party.FirstOrDefault(x => x.Name == characterName);
			if(charToPick==null)
            {
				throw new ArgumentException($"Character {characterName} not found!");
            }
			if (this.itemPool.Count == 0)
            {
				throw new InvalidOperationException("No items left in pool!");
            }
			Item itemToPick = (Item)this.itemPool[itemPool.Count - 1];
			charToPick.Bag.AddItem(itemToPick);

			return $"{characterName} picked up {itemToPick.GetType().Name}!";
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];
			var charToUse = this.party.FirstOrDefault(x => x.Name == characterName);
			if (charToUse == null)
			{
				throw new ArgumentException($"Character {characterName} not found!");
			}
			var itemToUse = charToUse.Bag.Items.FirstOrDefault(x => x.GetType().Name == itemName);
			itemToUse.AffectCharacter(charToUse);
			return $"{charToUse.Name} used {itemName}.";
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();
			var characters = this.party.OrderByDescending(x => x.IsAlive == true).ThenByDescending(x => x.Health);
			foreach(var character in characters)
            {
				string status = "Dead";
				if(character.IsAlive)
                {
					status = "Alive";
                }
				sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
				
            }
			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[1];
			var attacker = this.party.FirstOrDefault(x => x.Name == attackerName);
			var receiver = this.party.FirstOrDefault(x => x.Name == receiverName);
			if(attacker==null)
            {
				throw new ArgumentException($"Character {attackerName} not found!");

			}
			if (receiver == null)
			{
				throw new ArgumentException($"Character {receiverName} not found!");

			}

			if(attacker.GetType().Name=="Warrior")
            {
				Warrior attackerWarrior = attacker as Warrior;
				attackerWarrior.Attack(receiver);
            }
			else
            {
				throw new ArgumentException($"{attacker.Name} cannot attack!");
            }


			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points!{receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

			if (receiver.IsAlive == false)
			{
				sb.AppendLine($"{receiver.Name} is dead!");
			}

			return sb.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

			var healer = this.party.FirstOrDefault(x => x.Name == healerName);
			var receiver = this.party.FirstOrDefault(x => x.Name == healingReceiverName);
			if(healerName==null)
            {
				throw new ArgumentException($"Character {healerName} not found!");

			}
			if (receiver == null)
			{
				throw new ArgumentException($"Character {healingReceiverName} not found!");

			}

			if(healer.GetType().Name=="Priest")
            {
				Priest healerPriest = healer as Priest;
				healerPriest.Heal(receiver);
            }
			else
            {
				throw new ArgumentException($"{healer.Name} cannot heal!");
            }


			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!");

			return sb.ToString().TrimEnd();
		}
	}
}
