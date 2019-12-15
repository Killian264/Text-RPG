using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Killian_Text_RPG
{
	public class HumanWizard : Human, IWizard
    {
        public int SpellPoints { get; set; }

        public override void LevelUp()
        {
            var choices = Constants.WizardSpells.Where(spell => spell.Level == Level).ToList();
            Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Choose a new spell for this level: ");

            Spell choice ;
            do
            {
                choice = ListHelpers.PrintListGetItem(choices, PrintTypes.SpellsInformation) as Spell;
            }
            while (choice == null);

                ClassSpells.Add(choice);

            // Wizard Level UP stats
            Intelligence += 2;
            Constitution += 5;

        }

        public HumanWizard(string name)
        {
            Name = name;

            // Wizard Stats
            BaseAttackDamage -= 2;
            Intelligence += 11;
            Strength += 4;
            Dexterity += 4;
            Defence -= 2;

            SpellPoints = 10;
            Class = "Wizard";
            ClassSpells.Add(new Spell("Magic Missile", "Ranged shots", 6, 3, 0, "Intelligence", 40, "You shoot a missile and it ", "An entry level combat spell that allows a user to shoot from a distance and deal good damage."));

            return;
        }
        public HumanWizard(SaveModel player)
        {
            new Human(player, this);
            Class = "Wizard";
            return;
        }
    }
}
