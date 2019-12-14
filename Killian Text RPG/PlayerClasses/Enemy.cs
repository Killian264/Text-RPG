using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public class Enemy : Creature
	{
		private int RewardGold { get; set; }
        private int RewardExp { get; set; }
        string Description;
        private string EncounterString { get; set; }
        private string AttackString { get; set; }
        private string DeathString { get; set; }

        public void Die(Player player)
		{
            // this most likly would need to be tweaked or needed exp per level would need to rise by 30% per level 
            // I may want to make this a field later
            int rewardExp = (Level * 30) * 2;
            player.KillEnemy(RewardGold, rewardExp);
            LineHelpers.PrintLineWithContinue(DeathString);
            LineHelpers.PrintLineWithContinue("You gain " + RewardGold + " Gold and " + rewardExp + " Exp.");
        }
        public virtual void Attack(Player player)
        {
            AttackStringBuilder(player.TakeDamage(BaseAttackDamage), player.Name);
            //return damage;
        }
        // Note this should be deleted later in favor of a more robust system
        private void AttackStringBuilder(int damage, string enemyName)
        {
            // see comment about player attack string builder
            string attackState = "--did'nt round up fix Enemy.AttackStringBuilder--";
            if (damage <= 0) attackState = "misses you.";

            damage /= 3;
            if (damage == 1) attackState = "grazes you.";
            if (damage == 2) attackState = "hits you.";
            if (damage == 3) attackState = "slams into you.";
            if (damage > 3) attackState = "crushes you.";

            LineHelpers.PrintLineWithContinue(AttackString + attackState);
            LineHelpers.PrintLineWithContinue("You take " + (damage * 3) + " damage.");
        }
        public void Encounter()
        {
            LineHelpers.PrintLineWithContinue(EncounterString);
        }
        // Enemies are built in Constants.cs
        public Enemy(string name, string type, int health, int level, int attackDamage, int defence, int rewardGold, string attackString, string encounterString, string deathString, string description = "")
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
            DeathString = deathString;
        }
	}
}
