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
            //Console.WriteLine("120");
            //Console.WriteLine("-------------------------");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + player.Name + "  \t  HP: " + player.CurrentHealth + "/" + player.Constitution + "  \t  Level: "+ player.Level +
                "  \t  EXP: " + player.ExpCurrent + "/" + player.ExpNextLevel + "  \t  Class:" + player.Class + "  \t  Race: " + player.Type + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        public static void TempInterface(string name = "", string charRace = "", string charClass = "")
        {
            Console.Clear();
            //Console.WriteLine("120");
            //Console.WriteLine("-------------------------");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + name + "  \t  HP: 20/20  \t  Level: 1  \t  EXP: 234/1000  \t  Class:" + charClass + "  \t  Race: " + charRace + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        public static void BasicInterfaceWithDelegate()
        {
            Console.Clear();
            //Console.WriteLine("120");
            //Console.WriteLine("-------------------------");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: Killian  \t  HP: 20/20  \t  Level: 1  \t  EXP: 234/1000  \t  Class: Wizard  \t  Race: Dwarf \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        public static void CharacterSheet(Player player)
        {
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: Killian  \t  HP: 20/20  \t  Level: 1  \t  EXP: 234/1000  \t  Class: Wizard  \t  Race: Dwarf \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
        }
        public delegate void Function(string line);
        public static void BasicInterfaceDelegate(Player player, Function f, string line)
        {
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + player.Name + "  \t  HP: " + player.CurrentHealth + "/" + player.Constitution + "  \t  Level: " + player.Level +
                "  \t  EXP: " + player.ExpCurrent + "/" + player.ExpNextLevel + "  \t  Class:" + player.Class + "  \t  Race: " + player.Type + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            f(line);
        }
        public delegate void FunctionParams(string[] lines);
        public static void BasicInterfaceDelegateParams(Player player, FunctionParams f, params string[] line)
        {
            Console.Clear();
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("\n");
            Console.Write("  Name: " + player.Name + "  \t  HP: " + player.CurrentHealth + "/" + player.Constitution + "  \t  Level: " + player.Level +
                "  \t  EXP: " + player.ExpCurrent + "/" + player.ExpNextLevel + "  \t  Class:" + player.Class + "  \t  Race: " + player.Type + " \n");
            Console.Write("\n");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            f(line);
        }

    }
}
