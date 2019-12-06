using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanWarrior : Human, IWarrior
    {
        public int BlockChance { get; set; } = 5;

        public List<Spell> LevelUpWarrior()
        {
            throw new NotImplementedException();
        }

        public void PenetratingAttack()
		{
			throw new NotImplementedException();
		}

        public HumanWarrior(string name)
        {
            Name = name;

            // Warrior Stats
            BaseAttackDamage += 0;
            Intelligence += 0;
            Strength += 6;
            Dexterity += 8;
            Defence += 7;


            Class = "Warrior";

            return;
        }
        public HumanWarrior(SaveModel player)
        {
            new Human(player, this);
            Class = "Warrior";
            return;
        }
    }
}
