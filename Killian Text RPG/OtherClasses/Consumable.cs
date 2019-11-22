using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Consumable
	{
		string Name { get; }
        int HealAmount { get; }
        int ID { get; }

        public Consumable(string name, int healthAmount, int ID)
		{
			throw new NotImplementedException();
		}

        public int UseConsumable()
        {
            Console.WriteLine("You drink the " + Name + " and heal " + HealAmount + " HP");
            return HealAmount;
        }

	}
}
