using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
    // This could be a thing and probably should be but thats fine
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

        public int Use(Player player, string enemyName)
        {
            // Possibly add description here instead
            // Possible pass in enemy name here later
            // this could be moved to combat section ill know if its a good idea later
            LineHelpers.Print("The " + Name + " " + UseString);
            // This could be changed later depending on how much damage these spells do
            return Damage + (player.Level * 2) + ModifierHelper(player);

            // Add damage scaling stuff here later ^^^^
        }
        private int ModifierHelper(Player player)
        {
            // needs to be cast so its decimal arithmetic and not integer arithmetic
            decimal modifierPercent = (decimal)ModifierPercent / 100;
            if (Modifier == "Strength")
            {
                return Convert.ToInt32(player.Strength * modifierPercent);
            }
            else if (Modifier == "Intelligence")
            {
                return Convert.ToInt32(player.Intelligence * modifierPercent);
            }
            else if (Modifier == "Dexterity")
            {
                return Convert.ToInt32(player.Dexterity * modifierPercent);
            }
            return player.BaseAttackDamage;
        }

        public void Info(Player player)
        {
            //Output Interface Print Spell
            Sheets.Spell(player, this);
        }

        public Spell(string name, string type, int damage, int cost, int level, string modifier, int modifierPercent, string useString, string description)
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
