using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.OtherClasses.Things;

namespace Killian_Text_RPG.Helpers
{
    class ListHelpers
    {
        public static dynamic GetItemByIDHelper(dynamic list, int ID)
        {
            // Generic get ID
            foreach (dynamic thing in list)
            {
                if (thing.ID == ID)
                {
                    return thing;
                }
            }
            return null;
        }
        public static int[] PrintListHelper(dynamic list)
        {
            List<int> ret = new List<int>();
            foreach (var thing in list)
            {
                ret.Add(thing.ID);
                LineHelpers.PrintLine(thing.ID.ToString() + ". " + thing.Name);
                PrintHelper(thing);
            }
            LineHelpers.PrintLine(9 + ". Exit");
            ret.Add(9);
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

    }
}
