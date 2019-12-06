using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class DwarfWarrior : Dwarf, IWarrior
	{
        // 
        public int BlockChance { get; set; } = 5;

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

            // Warrior Stats
            BaseAttackDamage += 0;
            Intelligence += 0;
            Strength += 6;
            Dexterity += 8;
            Defence += 7;
            ClassSpells = new List<Spell>();

            Class = "Warrior";

            return;
        }
        public DwarfWarrior(SaveModel player)
        {
            new Dwarf(player, this);
            Class = "Warrior";
            return;
        }
    }
}
