using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public abstract class Player : Creature
    {
        protected int Intelligence;
        protected int Strength;
        protected int Dexterity;
        protected int Experience;
        public int ExpNextLevel { get; protected set; }
        public int ExpCurrent { get; protected set; }
        public string Class { get; protected set; }
        public List<Weapon> weapons { get; protected set; }
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
    }
}
