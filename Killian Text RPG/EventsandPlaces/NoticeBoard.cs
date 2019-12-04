using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.EventsandPlaces
{
    class NoticeBoard
    {
        public static void Check(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You walk up to a large weathered notice board with papers on it.");

            do
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Notice Board:", "1. Reports of goblins has been prevelant on the western road proceed with caution.", "2. Come to the inn for rest and drinks!", "3. Check out my shop for weapons, armor, and healing items.", "4. A bounty of 10000 gold pieces has been put on the clearing of the goblin cave to the west.", "5. Exit");

                LineHelpers.ReadInputNumber(new int[] {5});
                Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the notice board.");
                //LineHelpers.PrintLineWithContinue("You leave the notice board.");
                return;
            } while (true);
        }
    }
}
