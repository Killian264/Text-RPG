using Killian_Text_RPG.EventsandPlaces;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Events
{
    class Town
    {
        public static void Enter(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "Add story about town here............................................");

            do
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Town:", "1. Head West", "2. Enter Inn", "3. Enter Shop.", "4. Check Notice Board", "5. Character Sheet", "6. View Inventory", "7. Save and Quit Game");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4, 5, 6, 7 });

                Interface.BasicInterface(player);

                switch (type)
                {
                    case 1:
                        // Add later
                        break;
                    case 2:
                        Inn.Enter(player);
                        break;
                    case 3:
                        Shop.Enter(player);
                        break;
                    case 4:
                        NoticeBoard.Check(player);
                        break;
                    case 5:
                        Sheets.Character(player);
                        break;
                    case 6:
                        player.ViewInventory();
                        break;
                    default:
                        if(Game.Save(player)) return;
                        break;
                }
            } while (true);
        }
    }
}
