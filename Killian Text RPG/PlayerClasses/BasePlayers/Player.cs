using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OtherClasses;
using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Player : Creature
    {
        protected int Intelligence;
        protected int Strength;
        protected int Dexterity;
        protected int Experience;
        public int ExpNextLevel { get; protected set; }
        public int ExpCurrent { get; protected set; }
        public string Class { get; protected set; }

        public Weapon currWeapons { get; protected set; }
        public Armor currArmor { get; protected set; }

        public List<Weapon> weapons { get; protected set; }

        public List<Armor> Armor { get; protected set; }
        public List<Consumable> consumables { get; protected set; }

        public virtual int Attack()
        {
            throw new NotImplementedException();
        }

        public virtual void LevelUp()
        {
            throw new NotImplementedException();
        }

        public void ViewInventory()
        {
            throw new NotImplementedException();
        }

        public void EquipWeapon(int ID)
        {
            throw new NotImplementedException();
        }

        public void UseConsumable(int ID)
        {
            throw new NotImplementedException();
        }

        // Could use generic type and type checking to only have one func
        public void BuyItem(Thing item)
        {
            if(Gold < item.Cost)
            {
                LineHelpers.PrintLineWithContinue("You cannot afford this item.");
                return;
            }
            if (item is Weapon)
            {
                weapons.Add(item as Weapon);
            }
            else if (item is Armor)
            {
                Armor.Add(item as Armor);
            }
            else
            {
                consumables.Add(item as Consumable);
            }
        }
        // Player init
        public Player()
        {
            currWeapons = new Weapon("None", "None", 1, 1, 9999, 1);
            currArmor = new Armor("None", "None", 1, 9999, 1);
            weapons = new List<Weapon>();
            Armor = new List<Armor>();
            consumables = new List<Consumable>();
        }
    }
}
