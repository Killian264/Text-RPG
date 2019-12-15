using System;
using System.Collections.Generic;
using System.Text;
using Killian_Text_RPG.Helpers;

namespace Killian_Text_RPG
{
	public class DwarfRogue : Dwarf, IRogue
    {
        public int CritChance { get; set; } = 5;

        public List<Spell> LevelUpRogue()
        {
            throw new NotImplementedException();
        }
        // rogues have a 5% chance to crit and do double damage thus its overridden here
        public override int BaseAttack(Enemy enemy)
        {
            // damage is added here for a base attack this will be overridden for the Rogue class
            int weaponDps = new Random().Next(CurrentWeapon.MinDamage, CurrentWeapon.MaxDamage);
            int damage = BaseAttackDamage + weaponDps;
            damage *= (Strength / 12);

            damage = new Random().Next(0, 5) == 5 ? damage * 2 : damage;

            return damage;
        }

        public DwarfRogue(string name)
        {
            Name = name;

            // Rogue Stats
            BaseAttackDamage += 2;
            Intelligence += 2;
            Strength += 8;
            Dexterity += 6;


            Class = "Rogue";

            return;
        }
        public DwarfRogue(SaveModel player)
        {
            new Dwarf(player, this);
            Class = "Rogue";
            return;
        }
    }
}
