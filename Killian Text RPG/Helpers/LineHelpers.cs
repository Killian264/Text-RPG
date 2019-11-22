using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Killian_Text_RPG.Helpers
{
    class LineHelpers
    {
        public static void AnyKeyToContinue()
        {
            Print("\n");
            Print("Press any key to continue... ");
            Console.ReadKey(true);
        }
        public static string ReadLine()
        {
            var ret = Console.ReadLine();
            return (ret);
        }
        public static void StoryPrint(string storyline, Player player)
        {
            Console.Clear();
            Interface.BasicInterface(player);
            Print(storyline);
            AnyKeyToContinue();
        }
        public static void Print(string line)
        {
            foreach (char letter in line)
            {
                Thread.Sleep(30);
                Console.Write(letter);
            }
        }
        public static void PrintLine(string line)
        {
            foreach (char letter in line)
            {
                Thread.Sleep(30);
                Console.Write(letter);
            }
            Console.Write("\n");
        }
        public static void PrintLine(params string[] lines)
        {
            foreach (string line in lines)
            {
                PrintLine(line);
            }
        }
        public static void LinePrintwithContinue(string line)
        {
            Print(line);
            AnyKeyToContinue();
            Console.Clear();
        }

        public static int ReadInputNumber(int[] possibleInputs)
        {
            ConsoleKeyInfo UserInput;
            int input;
            do
            {
                UserInput = Console.ReadKey(true); 

                if (char.IsDigit(UserInput.KeyChar))
                {
                    input = int.Parse(UserInput.KeyChar.ToString());
                }
                else
                {
                    input = -1;
                }
            }
            while (CheckKey(possibleInputs, input));

            return input;
        }
        private static bool CheckKey(int[] possibleInputs, int input)
        {
            foreach(int number in possibleInputs)
            {
                if(number == input) return false;
            }
            return true;
        }
    }
}
