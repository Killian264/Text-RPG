using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Human : Player
	{
		public void PenetratingAttack()
		{
			throw new NotImplementedException();
		}
        protected Human()
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

            // Human Bonuses 
            Defence += 1;
            Strength += 1;
            Type = "Human";
        }
	}
}
