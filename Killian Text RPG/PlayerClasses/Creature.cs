using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public abstract class Creature
	{
        public int Constitution { get; protected set; }
        public int Level { get; protected set; }
        public string Name { get; protected set; }
        public int BaseAttackDamage { get; protected set; }
        public int Defence { get; protected set; }
        public int CurrentHealth { get; protected set; }
        public string Type { get; protected set; }

        public int Gold { get; protected set; }

        public bool IsDead()
        {
            return CurrentHealth <= 0;
        }

        public virtual int TakeDamage(int damage)
        {
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

	}
}
