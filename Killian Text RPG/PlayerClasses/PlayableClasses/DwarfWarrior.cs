using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class DwarfWarrior : Player, IWarrior
	{
        public int BlockChance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Block()
		{
			throw new NotImplementedException();
		}

		public void Bash()
		{
			throw new NotImplementedException();
		}

        public List<Spell> LevelUpWarrior()
        {
            throw new NotImplementedException();
        }

        public DwarfWarrior(string name)
        {
            Name = name;

            // Rogue Stats
            BaseAttackDamage += 0;
            Intelligence += 0;
            Strength += 6;
            Dexterity += 8;
            Defence += 7;


            Class = "Warrior";

            return;
        }
    }
}
