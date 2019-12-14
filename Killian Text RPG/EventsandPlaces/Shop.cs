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
            // Basic shop story
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "A bell rings as you enter the shop and a large man comes out of the back with a smithing apron and a hammer in his hand.");
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "The shopkeeper smiles. \"Feel free to look around the shop. We have weapons, armor, and potions.\" he puts down his hammer and begins polishing a large breastplate.");

            BuyItem(player);
        }
        private static void BuyItem(Player player)
        {
            // Inits a vender and allows player to buy an item.
            Vendor vendor = new Vendor();
            do
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Look at wares:", "1. Weapons", "2. Armor", "3. Consumables.", "4. Exit");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(player);

                Thing choice = null;
                switch (type)
                {
                    case 1:
                        choice = ListHelpers.PrintListGetItem(vendor.Weapon, PrintTypes.Weapon) as Weapon;
                        break;
                    case 2:
                        choice = ListHelpers.PrintListGetItem(vendor.Armor, PrintTypes.Armor) as Armor;
                        break;
                    case 3:
                        choice = ListHelpers.PrintListGetItem(vendor.Consumable, PrintTypes.Consumable) as Consumable;
                        break;
                    case 4:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the shop.");
                        return;
                }
                if (choice != null) player.BuyItem(choice);


            } while (true);

        }
    }
}
