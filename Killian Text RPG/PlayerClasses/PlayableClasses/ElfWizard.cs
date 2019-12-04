using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfWizard : Elf, IWizard
    {
        //public List<Spell> Spells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int SpellPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Spell> ClassSpells { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Spell> Spells { get; set; }
        public int SpellPoints { get; set; }
        public List<Spell> ClassSpells { get; set; }

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

            Spells = new List<Spell>();
            SpellPoints = 10;
            ClassSpells = new List<Spell>();


            Class = "Wizard";

            return;
        }
        public ElfWizard(SaveModel player)
        {
            throw new NotImplementedException();
        }
    }
}
