using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;

namespace Killian_Text_RPG.Helpers
{
    class ListHelpers
    {
        // These are the generic list helpers for stuff like armor and weapons and stuff for shops and for inventory now that I think about it why didnt I just use the input number and grab by list[inputnum]
        // figure out reason later

        // all of this should be refactored infavor of a better system using list[inputnum] and delegates for print type
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
        // dynamic should be extraordinarly slow, I could pass Thing and typecast but im lazy
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

        public delegate void PrintFunc(object item, int count);
        public static object PrintListGetItem<T>(List<T> list, PrintFunc Print)
        {
            int count = 0;
            while (true)
            {
                count = 0;
                foreach (var thing in list)
                {
                    Print(thing, count);
                    count++;
                }

                LineHelpers.PrintLine(count + ". Exit");
                LineHelpers.PrintLine("Type the number...");
                int choice = Convert.ToInt32(Console.ReadLine());


                // if some error here count -1
                if (choice < list.Count && choice > 0)
                 {
                    return list[choice];
                }
                if (choice == list.Count) return null;
            }
        }

    }
}
