using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;

namespace Killian_Text_RPG.OutputInterfaces
{
    class Sheets
    {
        private static void Print(Player player, List<string> print)
        {
            Interface.BasicInterface(player);
            foreach (string line in print)
            {
                LineHelpers.PrintLine(line);
            }
            LineHelpers.AnyKeyToContinue();
        }
        public static void Character(Player player)
        {
            List<string> print = new List<string>
            {
                "",
                "Name: " + player.Name,
                "Level: " + player.Level + " " + player.Type + " " + player.Class,
                "Current health: " + player.CurrentHealth + "/" + player.Constitution,
                "Experience to next level: " + (player.ExpNextLevel - player.ExpCurrent),
                "",
                "Constitution: " + player.Constitution,
                "Strength: " + player.Strength,
                "Intelligence: " + player.Intelligence,
                "Dexterity: " + player.Dexterity,
                "",
                "BaseAttackDamage: " + player.BaseAttackDamage,
                "BaseDefence: " + player.Defence,
                "Weapon: " + player.CurrentWeapon.Name + "\n   Damage: " + player.CurrentWeapon.MinDamage + "-" + player.CurrentWeapon.MaxDamage,
                "Armor: " + player.CurrentArmor.Name + "\n   Armor: " + player.CurrentArmor.ArmorRating,
                "",
                "Gold: " + player.Gold.ToString()
            };

            Print(player, print);
        }
        public static void Spell(Player player, Spell spell)
        {
            // Delete this comment after testing
            //Name = name;
            //Type = type;
            //Damage = damage;
            //Cost = cost;
            //Level = level;
            //Modifier = modifier;
            //ModifierPercent = modifierPercent;
            //UseString = useString;
            //Description = description;
            List<string> print = new List<string>
            {
                "",
                spell.Name,
                spell.Type,
                "Damage: " + spell.Damage,
                "Use Cost: " + spell.Cost,
                "",
                "Modifier: " + spell.Modifier,
                "Modifier Percentage: " + spell.ModifierPercent,
                "",
                "Description: " + spell.Description
            };

            Print(player, print);
        }
    }
}
