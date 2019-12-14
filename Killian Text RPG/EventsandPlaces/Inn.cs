using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.EventsandPlaces
{
    class Inn
    {
        public static void Enter(Player player)
        {
            // basic 
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You enter the inn and see that its full to the brim with people at every table. Some drinking and eating and others playing cards.");
            ShopChoices(player);
        }
        private static void ShopChoices(Player player)
        {
            // Inn choices this will go until player leaves
            while (true) {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "What can I do for you today?:", "1. Room - 10 gold", "   You rest for a day and your wounds are healed.", "2. Drink - 2 gold", "   You grab a drink and some of your wounds are healed.", "3. Ask for work.", "4. Exit");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(player);


                switch (type)
                {
                    case 1:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You awake with your wounds healed.");
                        player.Heal(1000);
                        return;
                    case 2:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLine, "You take a drink.");
                        player.Heal(Convert.ToInt32(player.CurrentHealth * .4));
                        break;
                    case 3:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "Check the bounty board outside.");
                        break;
                    default:
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the inn.");
                        return;
                }
            }
        }
    }
}
