using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Human : Player
	{
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
            ClassSpells.Add(new Spell("Penetrating Attack", "Stabbing", 10, 0, 0, "Strength", 100, "You lunge forward and slam down your sword into the enemy and ", "A simple attack meant to deal damage regardless of the armor level of the enemy."));
        }
    }
}
