using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Vendor
	{
		string name;
        // Make these constant after setup in constants
		List<Weapon> Weapon;
		List<Consumable> Consumable;

		public void BuyItem()
		{
			throw new NotImplementedException();
		}

        Vendor(string name)
        {
            return;
        }
	}
}
