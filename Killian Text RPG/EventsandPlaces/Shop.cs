using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Killian_Text_RPG
{
    class Shop
    {
        public static void EnterShop(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.LinePrintwithContinue, "The bell rings as you enter the shop and a large man comes out of the back with a smithing apron and a hammer in his hand.");
            Interface.BasicInterfaceDelegate(player, LineHelpers.LinePrintwithContinue, "The shopkeeper smiles. \"Feel free to look around the shop. We have weapons, armor, and potions.\" he puts down his hammer and begins polishing a large breastplate.");

            BuyItem(player);
        }
        public static void BuyItem(Player player)
        {
            Vendor vendor = new Vendor();
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
                        choices = BuyHelperPrintList(vendor.Weapon);
                        break;
                    case 2:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Armor: ");
                        choices = BuyHelperPrintList(vendor.Armor);
                        break;
                    case 3:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Consumables: ");
                        choices = BuyHelperPrintList(vendor.Consumable);
                        break;
                    case 4:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.LinePrintwithContinue, "You leave the shop");
                        return;
                    default:
                        return;
                }

                var ID = LineHelpers.ReadInputNumber(choices);
                // if crash subract length by 1
                if (ID == choices[choices.Length]) return;

                switch (ID)
                {
                    case 1:
                       player.AddWeapon(BuyHelper(vendor.Weapon, ID));
                        break;
                    case 2:
                        player.AddArmor(BuyHelper(vendor.Armor, ID));
                        break;
                    case 3:
                        player.AddConsumable(BuyHelper(vendor.Consumable, ID));
                        break;
                    case 4:
                        return;
                }

            } while ()

            switch (type)
            {
                case 1:
                    return (BuyHelper(Weapon, ID));
                case 2:
                    return (BuyHelper(Armor, ID));
                case 3:
                    return (BuyHelper(Consumable, ID));
                case 4:
                    return;
            }
            return null;
        }
        private static int[] BuyHelperPrintList<T>(List<T> list)
        {
            List<int> ret = new List<int>();
            foreach (T thing in list)
            {
                var id = Convert.ToInt32(thing.GetType().GetField("ID", BindingFlags.Public).GetValue(thing).GetType());
                ret.Add(id);
                var name = thing.GetType().GetField("Name", BindingFlags.Public).GetValue(thing).GetType().ToString();
                LineHelpers.PrintLine(id.ToString() + ". " + name);
            }
            // Final thingy is exit
            LineHelpers.PrintLine(ret.Count + 1 + ". Exit");
            ret.Add(ret.Count + 1);
            return ret.ToArray();
        }
        private static T BuyHelper<T>(List<T> list, int ID)
        {
            // Generic get ID
            foreach (T thing in list)
            {
                var idCheck = thing.GetType().GetField("ID", BindingFlags.Public);
                if (Convert.ToInt32(idCheck.GetValue(thing).GetType()) == ID)
                {
                    return thing;
                }
            }
            return list[0];
        }
    }
}
