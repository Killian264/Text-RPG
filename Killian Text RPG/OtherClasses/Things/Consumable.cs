using Killian_Text_RPG.OtherClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Consumable : Thing
	{
        int HealAmount { get; }

        public Consumable(string name, string description, int healAmount, int id, int cost)
        {
            Name = name;
            this.ID = id;
            HealAmount = healAmount;
            Description = description;
            Cost = cost;
        }

        public int UseConsumable()
        {
            Console.WriteLine("You drink the " + Name + " and heal " + HealAmount + " HP");
            return HealAmount;
        }

	}
}
