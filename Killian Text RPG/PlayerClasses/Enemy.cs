using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Enemy : Creature
	{
		int RewardGold;

		public void Die()
		{
			throw new NotImplementedException();
		}

		public Enemy(string name, string type, int health, int level, int attackDamage, int defence, int rewardGold)
		{
            Name = name;
            Type = type;
            Constitution = health;
            Level = level;
            BaseAttackDamage = attackDamage;
            Defence = defence;
            RewardGold = rewardGold;
		}
	}
}
