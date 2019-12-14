using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    class PrintTypes
    {
        // See ListHelpers for info on implementation
        public static void Weapon(object item, int count)
        {
            Weapon weapon = item as Weapon;
            LineHelpers.PrintLine(count + ". " + weapon.Name);
            LineHelpers.PrintLine("  " + weapon.Description);
            LineHelpers.PrintLine("  Cost: " + weapon.Cost);
            LineHelpers.PrintLine("  Damage: " + weapon.MinDamage + " to " + weapon.MaxDamage);
        }
        public static void Armor(object item, int count)
        {
            Armor armor = item as Armor;
            LineHelpers.PrintLine(count + ". " + armor.Name);
            LineHelpers.PrintLine("  " + armor.Description);
            LineHelpers.PrintLine("  Armor: " + armor.ArmorRating);
            LineHelpers.PrintLine("  Cost: " + armor.Cost);
        }
        public static void Consumable(object item, int count)
        {
            Consumable consumable = item as Consumable;
            LineHelpers.PrintLine(count + ". " + consumable.Name);
            LineHelpers.PrintLine("  " + consumable.Description);
            LineHelpers.PrintLine("  Cost: " + consumable.Cost);
            LineHelpers.PrintLine("  Heal: " + consumable.HealAmount);
        }
        public static void Spell(object item, int count)
        {
            Spell spell = item as Spell;
            LineHelpers.PrintLine(count + ". " + spell.Name);
            LineHelpers.PrintLine("  Damage: " + spell.Damage);
            LineHelpers.PrintLine("  Cost: " + spell.Cost);
        }
        public static void SpellsInformation(object item, int count)
        {
            Spell spell = item as Spell;
            LineHelpers.PrintLine(count + ". " + spell.Name);
            LineHelpers.PrintLine("  " + spell.Description);
            LineHelpers.PrintLine("  Damage: " + spell.Damage);
            LineHelpers.PrintLine("  Cost: " + spell.Cost);
            LineHelpers.PrintLine("  Modifier: " + spell.Modifier);
        }
    }
}
