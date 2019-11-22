using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;

namespace Killian_Text_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            LineHelpers.LinePrintwithContinue("This game is played using the keyboard type the number, letter, or word when prompted.");
            LineHelpers.PrintLine("Killian Debacker's Text RPG");
            LineHelpers.PrintLine("1. New Game");
            LineHelpers.PrintLine("2. Load Game");

            var input = LineHelpers.ReadInputNumber(new int[] { 1, 2 });

            LineHelpers.PrintLine("Killian Debacker's Text RPG");
            LineHelpers.PrintLine("1. New Game");
            LineHelpers.PrintLine("2. Load Game");
            input = LineHelpers.ReadInputNumber(new int[] { 1, 2 });

            Console.WriteLine("test");
            StoryStart.Start();
        }
    }

}

