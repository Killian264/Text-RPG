﻿using Killian_Text_RPG.Helpers;
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
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You enter the dungeon add event later");
            Interface.BasicInterfaceDelegate(player, LineHelpers.PrintLineWithContinue, "You enter the dungeon add event later");
            EnterDungeon(player);
        }
        private static void EnterDungeon(Player player)
        {
            for (int dungeonLevel = 0; dungeonLevel <= 10; dungeonLevel++)
            {
                if(dungeonLevel % 3 == 0)
                {
                    if (!Dungeon.Rest(player))
                        return;
                }
                else
                {
                    // Cool events would be random here

                    //continue dependent on choices and result here
                    if (!Combat.Enter(player, dungeonLevel)) 
                        return;

                    if (!AfterCombatChoices(player))
                        return;

                    // Add choices here to stay on current level or go up a level
                }
            }
        }
        // bool determines if player keeps going or leaves after event
        public static bool Rest(Player player)
        {
            return true;
        }

        // bool determines if player keeps going or leaves after event
        public static bool AfterCombatChoices(Player player)
        {
            return true;
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

        private static void DungeonChoiceAfterFight()
        {
            // Choices here after fight
        }
        private static void DungeonChoiceAtRest()
        {
            // Choices here after fight
        }
    }
}
