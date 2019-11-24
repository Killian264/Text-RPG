using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;

namespace Killian_Text_RPG.OutputInterfaces
{
    class CharacterSheet
    {
        public static void Display(Player player)
        {
            Interface.BasicInterface(player);
            List<string> print = new List<string>();
            print.Add("");
            print.Add("Name: " + player.Name);
            print.Add("Level: " + player.Level + " " + player.Type + " " + player.Class);
            print.Add("Current health: " + player.CurrentHealth + "/" + player.Constitution);
            print.Add("Experience to next level: " + (player.ExpNextLevel - player.ExpCurrent));
            print.Add("");
            print.Add("Constitution: " + player.Constitution);
            print.Add("Strength: " + player.Strength);
            print.Add("Intelligence: " + player.Intelligence);
            print.Add("Dexterity: " + player.Dexterity);
            print.Add("");
            print.Add("BaseAttackDamage: " + player.BaseAttackDamage);
            print.Add("BaseDefence: " + player.Defence);
            print.Add("Weapon: " + player.CurrentWeapon.Name + "\n   Damage: " + player.CurrentWeapon.MinDamage + "-" + player.CurrentWeapon.MaxDamage);
            print.Add("Armor: " + player.CurrentArmor.Name + "\n   Armor: " + player.CurrentArmor.ArmorRating);
            print.Add("");
            print.Add("Gold: " + player.Gold.ToString());

            foreach(string line in print)
            {
                LineHelpers.PrintLine(line);
            }
            LineHelpers.AnyKeyToContinue();
        }
    }
}
