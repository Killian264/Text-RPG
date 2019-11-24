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
            // Human Bonuses 
            Defence += 1;
            Strength += 1;
            Type = "Human";
        }
	}
}
