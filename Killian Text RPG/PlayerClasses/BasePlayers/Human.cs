using Killian_Text_RPG.Helpers;
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
        public Human(SaveModel player, Human that)
        {
            new Player(player, that);
            Type = "Human";
        }
    }
}
