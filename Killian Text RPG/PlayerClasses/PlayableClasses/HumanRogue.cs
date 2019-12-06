using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanRogue : Human, IRogue
	{
        public int CritChance { get; set; } = 5;

        public List<Spell> LevelUpRogue()
        {
            throw new NotImplementedException();
        }

        public void PenetratingAttack()
		{
			throw new NotImplementedException();
		}
        public HumanRogue(string name)
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
        public HumanRogue(SaveModel player)
        {
            new Human(player, this);
            Class = "Rogue";
            return;
        }
    }
}
