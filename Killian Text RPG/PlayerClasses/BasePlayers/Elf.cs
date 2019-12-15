using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Elf : Player
	{

        protected Elf()
        {
            // Elf Bonuses 
            Intelligence += 3;
            Strength -= 1;
            Dexterity -= 1;
            Type = "Elf";
        }
        public Elf(SaveModel player, Elf that)
        {
            new Player(player, that);
            Type = "Elf";
            ClassSpells.Add(new Spell("Quick Stab", "Stabbing", 6, 0, 0, "Strength", 100, "You extend your arm as fast as a snake would attack and lunge at the enemy and you ", "A simple attack that allows you to get a quick blow out of an unsuspecting enemy."));
        }
    }
}
