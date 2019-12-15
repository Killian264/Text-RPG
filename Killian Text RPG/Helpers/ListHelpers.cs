using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;

namespace Killian_Text_RPG.Helpers
{
    class ListHelpers
    {
        // this function takes a generic list and applies a function to it 
        // this delegate should work with anything in PrintTypes
        public delegate void PrintFunc(object item, int count);
        public static object PrintListGetItem<T>(List<T> list, PrintFunc Print)
        {
            int count;
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
                if (choice < list.Count && choice > 0 || choice == 0 && list.Count > 0)
                {
                    return list[choice];
                }
                // this checks if the choice is the right number or if the count is zero if the choice is zero
                if (choice == list.Count || list.Count == 0 && choice == 0) return null;
            }
        }

    }
}
