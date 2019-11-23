using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.OutputInterfaces
{
    class Interface
    {
        //public static void BasicInterface(Player player)
        public static void BasicInterface(Player player)
        {
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + player.Name + "  \t  HP: " + player.CurrentHealth + "/" + player.Constitution + "  \t  Level: "+ player.Level +
                "  \t  EXP: " + player.ExpCurrent + "/" + player.ExpNextLevel + "  \t  Class:" + player.Class + "  \t  Race: " + player.Type + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        // Tabs are dumb
        // They give off different lengths for no reason sometimes
        // Or they give off different lengths depending on spaces around them
        // I may make a function here later to count spaces and stuff to make this perfect but for now its whatever

        //Console.Write("  Name: {0}  \t  HP: {1}/{2}  \t  Level: {3}  \t  EXP: {4}/{5}  \t  Class: {6}  \t  Race: {7}",
        //    player.Name, player.CurrentHealth, player.Constitution, player.Level, player.ExpCurrent, player.ExpNextLevel, player.Class, player.Type);
        //Console.Write("\n");
        //Console.Write("  Weapon: {0}-{0}  \t  Armor: {1}  \t  Gold: {2}  \t  Base Attack: {3}  \t  Base Armor: {4}  \t  Date: {5} ",
        //    player.currWeapons.MinDamage, player.currWeapons.MaxDamage, player.currArmor.ArmorRating, player.Gold, player.BaseAttackDamage, player.Defence, DateTime.Now.ToString("mm/dd/yyyy"));
        //Console.Write("\n");
        public static void TempInterface(string name = "", string charRace = "", string charClass = "")
        {
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + name + "  \t  HP: 20/20  \t  Level: 1  \t  EXP: 234/1000  \t  Class:" + charClass + "  \t  Race: " + charRace + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        public delegate void Function(string line);
        public static void BasicInterfaceDelegate(Player player, Function f, string line)
        {
            BasicInterface(player);
            f(line);
        }
        public delegate void FunctionParams(string[] lines);
        public static void BasicInterfaceDelegateParams(Player player, FunctionParams f, params string[] line)
        {
            BasicInterface(player);
            f(line);
        }

    }
}
