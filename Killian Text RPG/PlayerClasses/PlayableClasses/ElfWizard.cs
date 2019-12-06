using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfWizard : Elf, IWizard
    { 
        public int SpellPoints { get; set; }

        public List<Spell> LevelUpMage()
        {
            throw new NotImplementedException();
        }

        public void QuickStab()
		{
			throw new NotImplementedException();
		}
        public ElfWizard(string name)
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
        public ElfWizard(SaveModel player)
        {
            new Elf(player, this);
            Class = "Wizard";
            return;
        }
    }
}
