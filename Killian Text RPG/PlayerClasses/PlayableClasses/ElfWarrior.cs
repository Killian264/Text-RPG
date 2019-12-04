using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfWarrior : Elf, IWarrior
    {
        public int BlockChance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Spell> LevelUpWarrior()
        {
            throw new NotImplementedException();
        }

        public void QuickStab()
		{
			throw new NotImplementedException();
		}
        public ElfWarrior(string name)
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
        public ElfWarrior(SaveModel player)
        {
            throw new NotImplementedException();
        }
    }
}
