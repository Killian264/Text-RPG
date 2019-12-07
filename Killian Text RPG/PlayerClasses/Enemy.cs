using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Enemy : Creature
	{
		private int RewardGold { get; set; }
        string Description;
        private string EncounterString { get; set; }
        private string AttackString { get; set; }

		public void Die()
		{
			throw new NotImplementedException();
		}
        public virtual void Attack(Player player)
        {
            AttackStringBuilder(player.TakeDamage(BaseAttackDamage), player.Name);
            //return damage;
        }
        // Note this should be deleted later in favor of a more robust system
        private void AttackStringBuilder(int damage, string enemyName)
        {
            string attackState = "--did'nt round up fix Enemy.AttackStringBuilder--";
            if (damage <= 0) attackState = "misses you.";

            damage /= 3;
            if (damage == 1) attackState = "grazes you.";
            if (damage == 2) attackState = "hits you.";
            if (damage == 3) attackState = "slams into you.";
            if (damage > 3) attackState = "crushes you.";

            LineHelpers.PrintLineWithContinue(AttackString + attackState);
            LineHelpers.PrintLineWithContinue("You take " + damage + " damage.");
        }
        public void Encounter()
        {
            LineHelpers.PrintLineWithContinue(EncounterString);
        }

        public Enemy(string name, string type, int health, int level, int attackDamage, int defence, int rewardGold, string attackString, string encounterString, string description = "")
		{
            Name = name;
            Type = type;
            Constitution = health;
            Level = level;
            BaseAttackDamage = attackDamage;
            Defence = defence;
            RewardGold = rewardGold;
            AttackString = attackString;
            EncounterString = encounterString;
            Description = description;
        }
	}
}
