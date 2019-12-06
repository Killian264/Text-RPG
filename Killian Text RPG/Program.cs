using Killian_Text_RPG.Events;
using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;

namespace Killian_Text_RPG
{
    class Program
    {
        static void Main()
        {
            // I may move this later for organization
            LineHelpers.PrintLineWithContinue("This game is played using the keyboard type the number, letter, or word when prompted.");
            while (true)
            {
                Console.Clear();
                LineHelpers.PrintLine("Killian Debacker's Text RPG");
                LineHelpers.PrintLine("1. New Game");
                LineHelpers.PrintLine("2. Load Game");

                var input = LineHelpers.ReadInputNumber(new int[] { 1, 2 });

                if(input == 1)
                {
                    if (Game.DeleteSave())
                    {
                        StoryStart.Start();
                    }
                }
                else
                {
                    Player player = Game.Load();
                    if (player != null)
                    {
                        Town.Enter(player);
                    }
                }
            }
        }
    }

}

