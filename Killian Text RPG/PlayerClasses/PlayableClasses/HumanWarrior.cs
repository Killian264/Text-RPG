using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanWarrior : Human, IWarrior
    {
        public int BlockChance { get; set; } = 5;

        public List<Spell> LevelUpWarrior()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            var choices = Constants.WarriorSpells.Where(spell => spell.Level == Level).ToList();
            Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Choose a new spell for this level: ");

            Spell choice;
            do
            {
                choice = ListHelpers.PrintListGetItem(choices, PrintTypes.SpellsInformation) as Spell;
            }
            while (choice == null);

            ClassSpells.Add(choice);

            // Warrior Level UP stats
            Dexterity += 1;
            Strength += 1;
            Constitution += 8;

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

        public HumanWarrior(string name)
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
        public HumanWarrior(SaveModel player)
        {
            new Human(player, this);
            Class = "Warrior";
            return;
        }
    }
}
