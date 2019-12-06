using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class DwarfWizard : Dwarf, IWizard
	{
        public int SpellPoints { get; set; }

        public void Block()
		{
			throw new NotImplementedException();
		}

		public void Bash()
		{
			throw new NotImplementedException();
		}

        public List<Spell> LevelUpMage()
        {
            throw new NotImplementedException();
        }

        public DwarfWizard(string name)
        {
            Name = name;

            // Wizard Stats
            BaseAttackDamage -= 2;
            Intelligence += 11;
            Strength += 4;
            Dexterity += 4;
            Defence -= 2;

            SpellPoints = 10;
            Class = "Wizard";

            return;
        }
        public DwarfWizard(SaveModel player)
        {
            new Dwarf(player, this);
            Class = "Wizard";
            return;
        }
    }
}
