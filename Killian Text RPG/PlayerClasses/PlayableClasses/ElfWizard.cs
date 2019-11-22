using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfWizard : Player, IMage
    {
        public List<Spell> Spells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SpellPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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


            Class = "Wizard";

            return;
        }
    }
}
