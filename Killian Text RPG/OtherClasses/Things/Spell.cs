using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Spell
	{
		public string Name { get; }
        public string Type { get; }
        public int Damage { get; }
        public int Cost { get; }
        public int Level { get; }
        public string Modifier { get; }
        public int ModifierPercent { get; }
        public string Description { get; }
        public string UseString { get; }

        public int Use(int playerLevel, string enemyName)
        {
            // Possibly add description here instead
            // Possible pass in enemy name here later
            // this could be moved to combat section ill know if its a good idea later
            Console.WriteLine("The " + Name + " " + UseString + " " + enemyName);
            // This could be changed later depending on how much damage these spells do
            return Damage + (playerLevel * 2);

            // Add damage scaling stuff here later ^^^^
        }
        public void Info(Player player)
        {
            //Output Interface Print Spell
            Sheets.Spell(player, this);
        }

        Spell(string name, string type, int damage, int cost, int level, string modifier, int modifierPercent, string useString, string description)
        {
            Name = name;
            Type = type;
            Damage = damage;
            Cost = cost;
            Level = level;
            Modifier = modifier;
            ModifierPercent = modifierPercent;
            UseString = useString;
            Description = description;
        }
	}
}
