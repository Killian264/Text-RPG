using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Dwarf : Player
	{
		public void Block()
		{
			throw new NotImplementedException();
		}

		public void Bash()
		{
			throw new NotImplementedException();
		}
        public Dwarf()
        {
            Level = 1;
            Defence = 5;
            CurrentHealth = 20;
            Constitution = 20;
            BaseAttackDamage = 10;
            Intelligence = 10;
            Strength = 10;
            Dexterity = 10;
            ExpCurrent = 0;
            ExpNextLevel = 1000;

            // Dwarf Bonuses 
            Defence += 2;
            Strength += 2;
            Dexterity -= 1;
            Type = "Dwarf";
        }
	}
}
