using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Events
{
    class Dungeon
    {
        public static void Enter(Player player)
        {
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "While traveling east you spot a sign warning of danger...");
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You continue forward and come upon a large cave and you enter it.");
            EnterDungeon(player);
        }
        private static void EnterDungeon(Player player)
        {
            // every three turns you rest
            // other than these turns you fight an enemy based on what level of the dungeon you are in
            for (int dungeonLevel = 0; dungeonLevel <= 10; dungeonLevel++)
            {
                if(dungeonLevel % 3 == 0)
                {
                    Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You come upon a small campsite next to the stairs. A small area for a fire and old equipment lie unused.");

                    int restChoice = Dungeon.Rest(player, dungeonLevel);

                    if (restChoice == -1) return;
                    else if (restChoice == 0)
                    {
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the dungeon and make your way back to town.");
                        return;
                    }

                    Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You move towards the stairs and move down into the dungeon...");
                }
                else
                {
                    // Cool events would be random here

                    //continue dependent on choices and result here
                    if (!Combat.Enter(player, dungeonLevel)) 
                        return;

                    // if game is beat
                    if(dungeonLevel == 9)
                    {
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "Congratulations you beat the game and saved the town and even got 10000 gold pieces. You can continue to play if you want but this is the end of the story.");
                        Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You leave the dungeon and make your way back to town.");
                    }

                    if (!AfterCombatChoices(player))
                        return;

                    LineHelpers.PrintLineWithContinue("You continue deeper into the cave...");

                    // Add choices here to stay on current level or go up a level
                }
            }
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You continue into the dungeon without looking back...");
        }
        // bool determines if player keeps going or leaves after event

        // -1 dead 0 leave 1 continue
        public static int Rest(Player player, int dungeonLevel)
        {
            while (true)
            {
                Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Campsite:", "1. Rest (Heal 75% of your health but risk monster attack)", "2. View Inventory", "3. Continue Deeper.", "4. Exit Dungeon");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(player);
                bool slept = false;
                switch (type)
                {
                    case 1:

                        if (slept)
                        {
                            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You cannot rest twice.");
                            break;
                        }
                        slept = true;

                        player.Heal(Convert.ToInt32(player.Constitution * .75));

                        if(new Random().Next(0, 10) > 7)
                        {
                            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You awake to a noise.");
                            if (!Combat.Enter(player, dungeonLevel - 2))
                                return -1;
                        }
                        else
                        {
                            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You awake feeling better.");
                        }
                        break;
                    case 2:
                        player.ViewInventory();
                        break;
                    case 3:
                        return 1;
                    case 4:
                        return 0 ;
                }
            }
        }

        // bool determines if player keeps going or leaves after event
        public static bool AfterCombatChoices(Player player)
        {
            Interface.BasicInterfaceDelegateParams(player, LineHelpers.PrintLine, "Continue?", "1. Yes", "2. No, ");

            int type = LineHelpers.ReadInputNumber(new int[] { 1, 2 });

            return type == 1 ? true : false;
        }
        // Level 1 
        // Enemy attack
        // After fight choices

        // Level 2
        // Enemy attack
        // After fight choices

        // Level 3
        // Rest area choices

        // Level 4
        // Enemy attack
        // After fight choices

        // Level 5
        // Enemy attack
        // After fight choices

        // Level 6
        // Rest area choices

        // Level 7 
        // Enemy attack
        // After fight choices

        // Level 8
        // Enemy attack
        // After fight choices

        // Level 9
        // Enemy attack
        // After fight choices

        // Level 10
        // Big Boss

        // This will be a loop with a events in between and information when seeing an enmy or moving down a level
        // I will need to probably have an array in Constants for this information and possibly information on encounters and stuff like that
        // ^ this would be called in Enenmy.Encounter

        // Ideas
        // -- Events such as branching paths and enemy camps.
        // -- Possibility of clearing levels of the mine
        // -- Drops from getting into certain levels of the mine
        // -- Armors made from crafting enemy parts or potion crafting <- this would need a whole entire inventory system just for holding enemy parts. That being said I could have a set of possible items and you wouldnt be able to open it or something like that. 

        // TODO
        // -- Combat
        // -- Dungeon
        // -- Polish up everything
        // -- Figure out what automatic unit testing is
        // -- Unit testing kinda <- this will test some functions for crashing but thats about it as its not possible really to have any other tests for a game like this.
        // -- Add more features if I really wanna
        // -- Submit final version
    }
}
