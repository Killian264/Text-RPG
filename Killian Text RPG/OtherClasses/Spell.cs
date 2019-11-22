using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Spell
	{
		string Name { get; }
        int Damage { get; }
		int Cost { get; }

        public int Use(int playerLevel, string enemyName)
        {
            // Possibly add description here instead
            // Possible pass in enemy name here later
            // this could be moved to combat section ill know if its a good idea later
            Console.WriteLine("The " + Name + " shoots out of your hand and hits the " + enemyName);
            // This could be changed later depending on how much damage these spells do
            return Damage + (playerLevel * 2);
        }

        Spell(string name, int damage, int cost)
        {

        }
	}
}
