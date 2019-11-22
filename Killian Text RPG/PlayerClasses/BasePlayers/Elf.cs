using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Elf : Player
	{
		public void QuickStab()
		{
			throw new NotImplementedException();
		}

        public Elf()
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

            // Elf Bonuses 
            Intelligence += 3;
            Strength -= 1;
            Dexterity -= 1;
            Type = "Elf";
        }
	}
}
