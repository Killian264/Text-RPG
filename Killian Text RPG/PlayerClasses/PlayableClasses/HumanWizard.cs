using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanWizard : Player, IMage
    {
        public List<Spell> Spells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SpellPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Spell> LevelUpMage()
        {
            throw new NotImplementedException();
        }

        public void PenetratingAttack()
		{
			throw new NotImplementedException();
		}
        public HumanWizard(string name)
        {
            Name = name;

            // Rogue Stats
            BaseAttackDamage += 2;
            Intelligence += 10;
            Strength += 4;
            Dexterity += 4;
            Defence -= 2;


            Class = "Wizard";

            return;
        }
    }
}