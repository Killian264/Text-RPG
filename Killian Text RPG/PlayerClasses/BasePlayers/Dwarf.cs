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
        protected Dwarf()
        {

            // Dwarf Bonuses 
            Defence += 2;
            Strength += 2;
            Dexterity -= 1;
            Type = "Dwarf";
        }
	}
}
