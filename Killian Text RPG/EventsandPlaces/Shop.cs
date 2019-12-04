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
        public static void Enter(Player player)
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
                        choices = ListHelpers.PrintListHelper(vendor.Weapon);
                        break;
                    case 2:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Armor: ");
                        choices = ListHelpers.PrintListHelper(vendor.Armor);
                        break;
                    case 3:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "Consumables: ");
                        choices = ListHelpers.PrintListHelper(vendor.Consumable);
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
                            player.BuyItem(ListHelpers.GetItemByIDHelper(vendor.Weapon, id));
                            break;
                        case 2:
                            player.BuyItem(ListHelpers.GetItemByIDHelper(vendor.Armor, id));
                            break;
                        case 3:
                            player.BuyItem(ListHelpers.GetItemByIDHelper(vendor.Consumable, id));
                            break;
                    }
                }

            } while (true);

        }
    }
}
