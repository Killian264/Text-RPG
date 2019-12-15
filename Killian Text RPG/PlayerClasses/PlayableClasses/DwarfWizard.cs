using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Killian_Text_RPG.OutputInterfaces;

namespace Killian_Text_RPG
{
	public class DwarfWizard : Dwarf, IWizard
	{
        public int SpellPoints { get; set; }

        public override void LevelUp()
        {
            var choices = Constants.WizardSpells.Where(spell => spell.Level == Level).ToList();
            Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Choose a new spell for this level: ");

            Spell choice;
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

        public DwarfWizard(string name)
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
            SpellPoints = 10;
            // See constants for more info on all the spells
            ClassSpells.Add(new Spell("Magic Missile", "Ranged shots", 6, 3, 0, "Intelligence", 40, "You shoot a missile and it ", "An entry level combat spell that allows a user to shoot from a distance and deal good damage."));

            return;
        }
        public DwarfWizard(SaveModel player)
        {
            new Dwarf(player, this);
            Class = "Wizard";
            return;
        }
    }
}
