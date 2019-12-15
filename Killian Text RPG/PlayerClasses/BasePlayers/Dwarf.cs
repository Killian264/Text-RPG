using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Dwarf : Player
	{

        protected Dwarf()
        {
            // Dwarf Bonuses 
            Defence += 2;
            Strength += 2;
            Dexterity -= 1;
            Type = "Dwarf";
        }
        public Dwarf(SaveModel player, Dwarf that)
        {
            new Player(player, that);
            Type = "Dwarf";
            ClassSpells.Add(new Spell("Shield Bash", "Blunt Attack", 6, 0, 0, "Dexterity", 100, "You slam your dwarven shield into the enemy and it ", "A simple attack every Dwarf learns in school to quickly push back and enemy and deal damage."));
        }
    }
}
