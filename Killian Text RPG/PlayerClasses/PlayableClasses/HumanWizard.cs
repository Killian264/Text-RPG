using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanWizard : Human, IWizard
    {
        public int SpellPoints { get; set; }

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
        public HumanWizard(SaveModel player)
        {
            new Human(player, this);
            Class = "Wizard";
            return;
        }
    }
}
