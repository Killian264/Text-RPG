using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Killian_Text_RPG
{
	public class Player : Creature
    {
        public int Intelligence { get; protected set; }
        public int Strength { get; protected set; }
        public int Dexterity { get; protected set; }
        public int ExpNextLevel { get; protected set; }
        public int ExpCurrent { get; protected set; }
        public string Class { get; protected set; }

        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public List<Weapon> Weapons { get; protected set; }

        public List<Armor> Armor { get; protected set; }
        public List<Consumable> Consumables { get; protected set; }
        public List<Spell> ClassSpells { get; protected set; }

        public void Attack(Enemy enemy)
        {
            // Player decides what he wants to do.
            // Possibly add a space for class spells later
            Interface.BasicInterfaceDelegateParams(this, LineHelpers.PrintLine, "Choose your attack:", "1. Attack with your weapon.", "2. Choose a spell", "3. Drink a potion");

            int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3 });

            Interface.BasicInterface(this);

            int[] choices;
            int damage = 0;
            switch (type)
            {
                case 1:
                    damage = this.BaseAttack(enemy);
                    break;
                case 2:
                    while (true) {
                        Spell choice = ListHelpers.PrintListGetItem(ClassSpells, PrintTypes.Spell) as Spell ;
                        damage = choice == null ? -1 : choice.Use(this, enemy.Name);
                    }
                    break; // <-- its impossible to fall through here but the compiler gets mad
                case 3:
                    Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Consumables: ");
                    choices = ListHelpers.PrintListHelper(this.Consumables);
                    int temp = choices[choices.Length - 1];
                    choices = new int[1];
                    choices[0] = temp;
                    break;
            }

            // I may want to decouple this later 
            AttackString(enemy.TakeDamage(damage), enemy.Name);

            //return damage;
        }

        // This function takes a delegate that could be any type that returns void and takes a Spell
        // You could also supplement this with a something similar to the output interfaces
        public delegate void Function(Spell spell);
        private void PrintSpells(Function print)
        {
            int i = 0;
            foreach(Spell spell in ClassSpells)
            {
                LineHelpers.PrintLine(i + ".");
                print(spell);
                i++;
            }
        }
        // These are helpers that decide how the spell is printed and more can be added easily
        private void PrintSpellsNameDamage(Spell spell)
        {
            LineHelpers.PrintLine(spell.Name);
            LineHelpers.PrintLine("  Damage: " + spell.Damage);
            LineHelpers.PrintLine("  Cost: " + spell.Cost);
        }
        private void PrintSpellsInformation(Spell spell)
        {
            LineHelpers.PrintLine(spell.Name);
            LineHelpers.PrintLine("  " + spell.Description);
            LineHelpers.PrintLine("  Damage: " + spell.Damage);
            LineHelpers.PrintLine("  Cost: " + spell.Cost);
            LineHelpers.PrintLine("  Modifier: " + spell.Modifier);
        }

        public virtual int BaseAttack(Enemy enemy)
        {
            // damage is added here for a base attack this will be overridden for the Rogue class
            int weaponDps = new Random().Next(CurrentWeapon.MinDamage, CurrentWeapon.MaxDamage);
            int damage = BaseAttackDamage + weaponDps;
            damage *= (Strength / 12);
            return damage;
        }
        // Note this should be deleted later in favor of a more robust system
        private void AttackString(int damage, string enemyName)
        {
            // this builds the attack string note that string is immutable StringBuilder would most likly be a better option here
            string attackState = "--did'nt round up fix Player.AttackString--";
            if (damage <= 0) attackState = "misses the ";

            damage /= 3;
            if (damage == 1) attackState = "grazes the ";
            if (damage == 2) attackState = "hits the ";
            if (damage == 3) attackState = "slams into the ";
            if (damage > 3) attackState = "crushes the ";

            LineHelpers.PrintLineWithContinue(("You swing your " + this.CurrentWeapon.Name + " and it " + attackState + enemyName + "."));
        }
        public void KillEnemy(int gold, int exp)
        {
            // Player is updated with information after enenmy dies here
            Gold += gold;
            ExpCurrent += exp;

            if(ExpCurrent >= ExpNextLevel)
            {
                var extraExp = ExpCurrent - ExpNextLevel; 
                this.LevelUp();
                ExpCurrent = extraExp;
                // note this is where next exp is set but later this could be made by some calculation like ExpNextLevel *= 1.30 + 500 or something like that.
                ExpNextLevel += 500;
            }
        }
        public virtual void LevelUp()
        {
            throw new NotImplementedException();
        }
        public virtual void Heal(int HP)
        {
            CurrentHealth = CurrentHealth + HP > Constitution ? Constitution : CurrentHealth + HP;
        }
        public void ViewInventory()
        {
            // This is almost an exact copy of the Shop.cs do while possibly rework later
            do
            {
                // See shop.cs for explination of this 
                Interface.BasicInterfaceDelegateParams(this, LineHelpers.PrintLine, "Your Inventory:", "1. Weapons", "2. Armor", "3. Consumables.", "4. Exit");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(this);

                Thing choice;
                switch (type)
                {
                    case 1:
                        Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Weapons: ");
                        choice = ListHelpers.PrintListGetItem(this.Weapons, PrintTypes.Weapon) as Weapon;
                        break;
                    case 2:
                        choice = ListHelpers.PrintListGetItem(this.Armor, PrintTypes.Armor) as Armor;
                        break;
                    case 3:
                        choice = ListHelpers.PrintListGetItem(this.Consumables, PrintTypes.Consumable) as Consumable;
                        break;
                    default:
                        return;
                }
                if (choice != null)
                {
                    try
                    {
                        if(type == 1)
                        {
                            EquipWeapon(choice as Weapon);
                        }
                        else
                        {
                            EquipArmor(choice as Armor);
                        }
                    }
                    // this should never be nessicary 
                    catch(Exception ex)
                    {
                        LineHelpers.PrintLine("Unable to equip Item.");
                    }
                }

            } while (true);
        }

        public void EquipWeapon(Weapon weapon)
        {
            this.Weapons.Add(CurrentWeapon);
            CurrentWeapon = weapon;
            this.Weapons.Remove(weapon);
        }
        public void EquipArmor(Armor armor)
        {
            this.Armor.Add(CurrentArmor);
            CurrentArmor = armor;
            this.Armor.Remove(armor);
        }

        public void UseConsumable(Consumable consumable)
        {
            // if error here somehow player chose consumable that doesnt exist
            Consumables.Remove(consumable);
            this.Heal(consumable.Use());
        }

        // Could use generic type and type checking to only have one func
        public void BuyItem(Thing item)
        {
            // this function takes an item checks if a user can afford it
            // then type checks it to and adds it to list unless player already owns it
            // then subtracts cost from gold
            if (Gold < item.Cost)
            {
                LineHelpers.PrintLineWithContinue("You cannot afford this item.");
                return;
            }
            if (item is Weapon)
            {
                Weapon weapon = item as Weapon;
                if (this.Weapons.Contains(weapon))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Weapons.Add(item as Weapon);
            }
            else if (item is Armor)
            {
                Armor armor = item as Armor;
                if (this.Armor.Contains(armor))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Armor.Add(armor);
            }
            else if (item is Consumable)
            {
                Consumable consumable = item as Consumable;
                if (this.Consumables.Contains(consumable))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Consumables.Add(consumable);
            }
            LineHelpers.PrintLineWithContinue("The item has been added to your inventory.");
            Gold -= item.Cost;
        }
        private bool ExistHelper<T>(List<T> list, T item)
        {
            // generic list contains func this could be removed 
            return list.Contains(item); 
        }

        // self explanatory
        public Player()
        {
            // Base Stats
            Level = 1;
            Defence = 5;
            CurrentHealth = 20;
            Constitution = 20;
            BaseAttackDamage = 10;
            Intelligence = 10;
            Strength = 10;
            Dexterity = 10;
            ExpCurrent = 0;
            ExpNextLevel = 1000;
            Gold = 20;

            // Object init
            CurrentWeapon = new Weapon("Unarmed", "No weapon.", 1, 1, 0, 1);
            CurrentArmor = new Armor("Wool Shirt", "A wool shirt.", 1, 0, 1);
            Weapons = new List<Weapon>();
            Armor = new List<Armor>();
            Consumables = new List<Consumable>();
            ClassSpells = new List<Spell>();
        }
        // Check SaveModel and Save for more information on the use of this method
        public Player(SaveModel player, Player that)
        {
            that.Level = player.Level;
            that.Defence = player.Defence;
            that.CurrentHealth = player.CurrentHealth;
            that.Constitution = player.Constitution;
            that.BaseAttackDamage = player.BaseAttackDamage;
            that.Intelligence = player.Intelligence;
            that.Strength = player.Strength;
            that.Dexterity = player.Dexterity;
            that.ExpCurrent = player.ExpCurrent;
            that.ExpNextLevel = player.ExpNextLevel;
            that.Gold = player.Gold;
            that.Name = player.Name;

            // Object init
            that.CurrentWeapon = player.CurrentWeapon;
            that.CurrentArmor = player.CurrentArmor;
            that.Weapons = player.Weapons;
            that.Armor = player.Armor;
            that.Consumables = player.Consumables;
            that.ClassSpells = player.ClassSpells;
        }
    }
}
