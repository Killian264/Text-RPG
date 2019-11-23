using Killian_Text_RPG.OtherClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Weapon : Thing
	{
		public int MinDamage { get; }
        public int MaxDamage { get; }

        public Weapon(string name, string description, int minDamage, int maxDamage, int id, int cost)
        {
            Name = name;
            this.ID = id;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
            Cost = cost;
        }
    }
}
