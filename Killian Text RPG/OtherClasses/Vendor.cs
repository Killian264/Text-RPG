using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Killian_Text_RPG;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using Killian_Text_RPG.OutputInterfaces;

namespace Killian_Text_RPG
{
	public class Vendor
	{
        public string Name { get; } = "Vendor Venderson";
        public List<Weapon> Weapon { get; } = Constants.Weapons;
        public List<Armor> Armor { get; } = Constants.Armors;
        public List<Consumable> Consumable { get; } = Constants.Consumables;


        // this could be built out later to have multiple vendors and an actual constructor but for now this is fine as there is only one shop
        public Vendor()
        {
            return;
        }
	}
}
