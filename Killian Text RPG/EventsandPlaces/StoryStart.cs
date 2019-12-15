using Killian_Text_RPG.Events;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
    class StoryStart
    {
        public static void Start()
        {
            Player player = CharacterBuilder.BuildCharacter();
            LineHelpers.StoryPrint("As you enter the town you a man comes up to you and asks if you are the hero they hired. You tell them no but ask what the issue is. He tells you of creatures leaving a cave to the west and a bounty of 10000 gold on a Troll Warlord in the cave.", player);

            Town.Enter(player);
        }
    }
}
