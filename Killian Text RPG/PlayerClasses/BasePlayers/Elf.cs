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

        protected Elf()
        {
            // Elf Bonuses 
            Intelligence += 3;
            Strength -= 1;
            Dexterity -= 1;
            Type = "Elf";
        }
	}
}
