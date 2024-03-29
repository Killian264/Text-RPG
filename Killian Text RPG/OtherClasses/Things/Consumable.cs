using Killian_Text_RPG.OtherClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Consumable : Thing
	{
        public int HealAmount { get; }

        public Consumable(string name, string description, int healAmount, int cost)
        {
            Name = name;
            HealAmount = healAmount;
            Description = description;
            Cost = cost;
        }

        public int Use()
        {
            Console.WriteLine("You drink the " + Name + " and heal " + HealAmount + " HP");
            return HealAmount;
        }

	}
}
