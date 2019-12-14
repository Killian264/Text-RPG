using Killian_Text_RPG.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Killian_Text_RPG.Events
{
    class Combat
    {
        public static void Enter(Player player, int dungeonLevel)
        {
            List<Enemy> enemyChoices = Constants.Enemies.Where(enemy => enemy.Level == dungeonLevel).ToList();

            // new random is init here but you could make a variable instead and use that.
            Enemy enemy = enemyChoices[new Random().Next(enemyChoices.Count())];

            // Player attacks first

            // While enemy not dead

                // Enemy attacks
                    // func returns

                // Check player dead 

                // Player attacks

            // Enemy.Die
            // return
            
        }
    }
}
