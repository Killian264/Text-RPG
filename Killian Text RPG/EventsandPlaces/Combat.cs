using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Killian_Text_RPG.Events
{
    class Combat
    {
        public static bool Enter(Player player, int dungeonLevel)
        {
            List<Enemy> enemyChoices = Constants.Enemies.Where(enemy => enemy.Level == dungeonLevel).ToList();

            // new random is init here but you could make a variable instead and use that.
            Enemy enemy = enemyChoices[new Random().Next(enemyChoices.Count())];

            // Player attacks first
            player.Attack(enemy);

            // While enemy not dead
            while (enemy.IsDead())
            {
                enemy.Attack(player);

                if (player.IsDead())
                {
                    player.Die();
                    // Awake is called here to not complicate other functions
                    player.Awake();
                    return false;
                }

                player.Attack(enemy);

            }
            enemy.Die(player);
            return true;
        }
    }
}
