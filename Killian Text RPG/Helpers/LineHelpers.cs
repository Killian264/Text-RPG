﻿using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Killian_Text_RPG.Helpers
{
    class LineHelpers
    {
        // Speed at which text moves
        static readonly int speed = 10;

        // These are the line helpers and should be used instead of the Console Library
        // Many of these can be used by passing the function to the HeaderBar.cs functions that use delegates
        // Line at the end denotes that it will use the line if it doesnt use this it will print or read without using or making a newline Console.Write() vs Console.WriteLine()
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
                Thread.Sleep(speed);
                Console.Write(letter);
            }
        }
        public static void PrintLine(string line)
        {
            foreach (char letter in line)
            {
                Thread.Sleep(speed);
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
        public static void PrintLineWithContinue(string line)
        {
            Print(line);
            AnyKeyToContinue();
            Console.Clear();
        }

        public static int ReadInputNumber(int[] possibleInputs)
        {
            // User input key is read as ConsoleKeyInfo a class 
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
