using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;

namespace Killian_Text_RPG.OutputInterfaces
{
    class Sheets
    {

        // These are sheets like a CharacterSheet there are also PrintTypes for smaller objects that will be shown multiple at a time
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
            // Simple list structures like this are pretty clean but harder to read imo see base class init for more information on any attribute
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
            // more detailed version of PrintType meant to be shown one at a time
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
