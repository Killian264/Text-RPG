using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        public virtual int Attack()
        {
            int weaponDps = new Random().Next(CurrentWeapon.MinDamage, CurrentWeapon.MaxDamage);
            int damage = BaseAttackDamage + weaponDps;
            damage *= (Strength / 12);
            return damage;
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
                Interface.BasicInterfaceDelegateParams(this, LineHelpers.PrintLine, "Your Inventory:", "1. Weapons", "2. Armor", "3. Consumables.", "4. Exit");

                int type = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3, 4 });

                Interface.BasicInterface(this);

                int[] choices;
                switch (type)
                {
                    case 1:
                        Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Weapons: ");
                        choices = ListHelpers.PrintListHelper(this.Weapons);
                        break;
                    case 2:
                        Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Armor: ");
                        choices = ListHelpers.PrintListHelper(this.Armor);
                        break;
                    case 3:
                        Interface.BasicInterfaceDelegate(this, LineHelpers.PrintLine, "Consumables: ");
                        choices = ListHelpers.PrintListHelper(this.Consumables);
                        int temp = choices[choices.Length - 1];
                        choices = new int[1];
                        choices[0] = temp;
                        break;
                    default:
                        return;
                }

                int id = LineHelpers.ReadInputNumber(choices);
                if (id != choices[choices.Length - 1])
                {
                    try
                    {
                        if(type == 1)
                        {
                            EquipWeapon(id);
                        }
                        else
                        {
                            EquipArmor(id);
                        }
                    }
                    catch(Exception ex)
                    {
                        LineHelpers.PrintLine("Unable to equip Item.");
                    }
                }

            } while (true);
        }

        public void EquipWeapon(int id)
        {
            foreach (Weapon weapon in this.Weapons) 
            {
                if(weapon.ID == id)
                {
                    this.Weapons.Add(CurrentWeapon);
                    CurrentWeapon = weapon;
                    this.Weapons.Remove(weapon);
                }
            }
        }
        public void EquipArmor(int id)
        {
            foreach (Armor armor in this.Armor)
            {
                if (armor.ID == id)
                {
                    this.Armor.Add(CurrentArmor);
                    CurrentArmor = armor;
                    this.Armor.Remove(armor);
                }
            }
        }

        public void UseConsumable(int ID)
        {
            throw new NotImplementedException();
        }

        // Could use generic type and type checking to only have one func
        public void BuyItem(Thing item)
        {
            if (Gold < item.Cost)
            {
                LineHelpers.PrintLineWithContinue("You cannot afford this item.");
                return;
            }
            if (item is Weapon)
            {
                if(ExistHelper(this.Weapons, item.ID))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Weapons.Add(item as Weapon);
            }
            else if (item is Armor)
            {
                if (ExistHelper(this.Armor, item.ID))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Armor.Add(item as Armor);
            }
            else
            {
                if (ExistHelper(this.Consumables, item.ID))
                {
                    LineHelpers.PrintLineWithContinue("You already own this item.");
                    return;
                }
                Consumables.Add(item as Consumable);
            }
            LineHelpers.PrintLineWithContinue("The item has been added to your inventory.");
        }
        private bool ExistHelper<T>(List<T> list, int id)
        {
            return (ListHelpers.GetItemByIDHelper(list, id) != null); 
        }
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
        }
    }
}
