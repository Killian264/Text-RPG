using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Killian_Text_RPG
{
    class Shop
    {
        public static void EnterShop(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "A bell rings as you enter the shop and a large man comes out of the back with a smithing apron and a hammer in his hand.");
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "The shopkeeper smiles. \"Feel free to look around the shop. We have weapons, armor, and potions.\" he puts down his hammer and begins polishing a large breastplate.");

            BuyItem(player);
        }
        private static void BuyItem(Player player)
        {
            Vendor vendor = new Vendor();
            do
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Look at wares:", "1. Weapons", "2. Armor", "3. Consumables.", "4. Exit");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

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
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the shop.");
                        return;
                    default:
                        return;
                }

                int id = LineHelpers.ReadInputNumber(choices);
                if (id != choices[choices.Length - 1])
                {
                    switch (type)
                    {
                        case 1:
                            player.BuyItem(BuyHelper(vendor.Weapon, id));
                            break;
                        case 2:
                            player.BuyItem(BuyHelper(vendor.Armor, id));
                            break;
                        case 3:
                            player.BuyItem(BuyHelper(vendor.Consumable, id));
                            break;
                    }
                }

            } while (true);

        }
        //private static int[] BuyHelperPrintList2<T>(List<T> list)
        //{
        //    List<int> ret = new List<int>(); 
        //    foreach (var thing in list)
        //    {
        //        var test = thing as Thing;
        //        ret.Add(test.ID);
        //        LineHelpers.PrintLine(test.ID.ToString() + ". " + test.Name);
        //        PrintHelper(thing);
        //    }
        //    LineHelpers.PrintLine(ret.Count + 1 + ". Exit");
        //    ret.Add(ret.Count + 1);
        //    return ret.ToArray();
        //}
        //private static void PrintHelper(Thing item)
        //{
        //    if (item is Weapon)
        //    {
        //        var test = item as Weapon;
        //        LineHelpers.PrintLine("  " + test.Description);
        //        LineHelpers.PrintLine("  Cost: " + test.Cost);
        //        LineHelpers.PrintLine("  Damage: " + test.MinDamage + " to " + test.MaxDamage);
        //    }
        //    else if (item is Armor)
        //    {
        //        var test = item as Armor;
        //        LineHelpers.PrintLine("  " + test.Description);
        //        LineHelpers.PrintLine("  Armor: " + test.ArmorRating);
        //        LineHelpers.PrintLine("  Cost: " + test.Cost);
        //    }
        //    else
        //    {
        //        var test = item as Consumable;
        //        LineHelpers.PrintLine("  " + test.Description);
        //        LineHelpers.PrintLine("  Cost: " + test.Cost);
        //        LineHelpers.PrintLine("  Heal: " + test.HealAmount);
        //    }
        //}
        //private static int[] BuyHelperPrintList(int choice, int id)
        //{
        //    List<int> ret = new List<int>();
        //    foreach (var thing in list)
        //    {
        //        ret.Add(thing.ID);
        //        LineHelpers.PrintLine(thing.ID.ToString() + ". " + thing.Name);
        //        PrintHelper(thing);
        //    }
        //    LineHelpers.PrintLine(ret.Count + 1 + ". Exit");
        //    ret.Add(ret.Count + 1);
        //    return ret.ToArray();
        //}
        private static int[] BuyHelperPrintList(dynamic list)
        {
            List<int> ret = new List<int>();
            foreach (var thing in list)
            {
                ret.Add(thing.ID);
                LineHelpers.PrintLine(thing.ID.ToString() + ". " + thing.Name);
                PrintHelper(thing);
            }
            LineHelpers.PrintLine(ret.Count + 1 + ". Exit");
            ret.Add(ret.Count + 1);
            return ret.ToArray();
        }
        private static void PrintHelper(dynamic item)
        {
            if (item is Weapon)
            {
                LineHelpers.PrintLine("  " + item.Description);
                LineHelpers.PrintLine("  Cost: " + item.Cost);
                LineHelpers.PrintLine("  Damage: " + item.MinDamage + " to " + item.MaxDamage);
            }
            else if (item is Armor)
            {
                LineHelpers.PrintLine("  " + item.Description);
                LineHelpers.PrintLine("  Armor: " + item.ArmorRating);
                LineHelpers.PrintLine("  Cost: " + item.Cost);
            }
            else
            {
                LineHelpers.PrintLine("  " + item.Description);
                LineHelpers.PrintLine("  Cost: " + item.Cost);
                LineHelpers.PrintLine("  Heal: " + item.HealAmount);
            }
        }
        private static dynamic BuyHelper(dynamic list, int ID)
        {
            // Generic get ID
            foreach (dynamic thing in list)
            {
                if (thing.ID == ID)
                {
                    return thing;
                }
            }
            return list[0];
        }
    }
}
