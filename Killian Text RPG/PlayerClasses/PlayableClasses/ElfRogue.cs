using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfRogue : Elf, IRogue
    {
        public int CritChance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Spell> LevelUpRogue()
        {
            throw new NotImplementedException();
        }

        public void QuickStab()
		{
			throw new NotImplementedException();
		}
        public ElfRogue(string name)
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
        public ElfRogue(SaveModel player)
        {
            throw new NotImplementedException();
        }
    }
}
