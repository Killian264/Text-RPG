using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Events
{
    class Town
    {
        public static void EnterTown(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "Add story about town here............................................");


        }
    }
}
