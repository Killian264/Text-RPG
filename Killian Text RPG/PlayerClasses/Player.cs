using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Player : Creature
    {
        int Intelligence;
        int Strength;
        int Dexterity;
        int Experience;
        string Class;
        List<Weapon> weapons;
        List<Consumable> consumables;

        public Player()
        {
            throw new NotImplementedException();
        }

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
