using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class ElfWarrior : Elf, IWarrior
    {
        public int BlockChance { get; set; } = 5;

        public List<Spell> LevelUpWarrior()
        {
            throw new NotImplementedException();
        }

        // warriors have a 5% block chance and thus the takedamage is overridden
        public override int TakeDamage(int damage)
        {
            if (new Random().Next(0, 5) == 5)
            {
                LineHelpers.PrintLine("You block the attack and take no damage. \n");
                return 0;
            }
            if (Convert.ToInt32(damage * .7) < Defence)
            {
                int ret = Convert.ToInt32(damage * .3);
                CurrentHealth -= ret;
                return ret;
            }

            damage -= Defence;
            CurrentHealth -= damage;
            return damage;
        }
        public ElfWarrior(string name)
        {
            Name = name;

            // Warrior Stats
            BaseAttackDamage += 0;
            Intelligence += 0;
            Strength += 6;
            Dexterity += 8;
            Defence += 7;


            Class = "Warrior";

            return;
        }
        public ElfWarrior(SaveModel player)
        {
            new Elf(player, this);
            Class = "Warrior";
            return;
        }
    }
}
