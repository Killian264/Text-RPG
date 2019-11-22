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
        // Make these constant after setup in constants
        public List<Weapon> Weapon { get; } = Constants.Weapons;
        public List<Armor> Armor { get; } = Constants.Armors;
        public List<Consumable> Consumable { get; } = Constants.Consumables;

        public Thing BuyItem(Player player)
		{
            Interface.BasicInterfaceDelegate(player, LineHelpers.LinePrintwithContinue, "The bell rings as you enter the shop and a large man comes out of the back with a smithing apron and a hammer in his hand.");
            Interface.BasicInterfaceDelegate(player, LineHelpers.LinePrintwithContinue, "The shopkeeper smiles. \"Feel free to look around the shop. We have weapons, armor, and potions.\" he puts down his hammer and begins polishing a large breastplate.");
            int type;
            int ID;
            do
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Look at wares:", "1. Weapons", "2. Armor", "3. Consumables. 4. Exit");

                type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(player);

                int[] choices;
                switch (type)
                {
                    case 1:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Weapons: ");
                        choices = BuyHelperPrintList(Weapon);
                        break;
                    case 2:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Armor: ");
                        choices = BuyHelperPrintList(Armor);
                        break;
                    case 3:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Consumables: ");
                        choices = BuyHelperPrintList(Consumable);
                        break;
                    case 4:
                        return null;
                }

            } while()

            switch (type)
            {
                case 1:
                    return (BuyHelper(Weapon, ID));
                case 2:
                    return (BuyHelper(Armor, ID));
                case 3:
                    return (BuyHelper(Consumable, ID));
                case 4:
                    return null;
            }
            return null;
		}
        private int[] BuyHelperPrintList<T>(List<T> list)
        {
            List<int> ret = new List<int>();
            foreach (T thing in list)
            {
                var id = Convert.ToInt32(thing.GetType().GetField("ID", BindingFlags.Public).GetValue(thing).GetType());
                ret.Add(id);
                var name = thing.GetType().GetField("Name", BindingFlags.Public).GetValue(thing).GetType().ToString();
                LineHelpers.PrintLine(id.ToString() + ". " + name);
            }
            ret.Add(ret.Count + 1);
            return ret.ToArray();
        }
        private T BuyHelper<T>(List<T> list, int ID)
        {
            foreach(T thing in list)
            {
                var idCheck = thing.GetType().GetField("ID", BindingFlags.Public);
                if (Convert.ToInt32(idCheck.GetValue(thing).GetType()) == ID)
                {
                    return thing;
                }
            }
            return list[0];
        }

        public Vendor()
        {
            return;
        }
	}
}
