using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.Helpers;

namespace Killian_Text_RPG
{
	public class DwarfRogue : Dwarf, IRogue
    {
        public int CritChance { get; set; } = 5;

        public void Block()
		{
			throw new NotImplementedException();
		}

		public void Bash()
		{
			throw new NotImplementedException();
		}

        public List<Spell> LevelUpRogue()
        {
            throw new NotImplementedException();
        }

        public DwarfRogue(string name)
        {
            Name = name;

            // Rogue Stats
            BaseAttackDamage += 2;
            Intelligence += 2;
            Strength += 8;
            Dexterity += 6;


            Class = "Rogue";

            return;
        }
        public DwarfRogue(SaveModel player)
        {
            new Dwarf(player, this);
            Class = "Rogue";
            return;
        }
    }
}
