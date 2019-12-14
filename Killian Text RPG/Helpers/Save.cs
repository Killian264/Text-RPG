using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    class Game
    {
        private readonly static string LocalSavePath = "..\\..\\..\\Helpers\\Save.json";

        // These are the save helpers they serialize an object and print it to a file
        // Upon load they read and unserialize the object and move it to a Model that will be used to init the character
        public static bool Save(Player player)
        {
            try
            {
                string jsonToSave = JsonConvert.SerializeObject(player);
                File.WriteAllText(LocalSavePath, jsonToSave);
                LineHelpers.PrintLineWithContinue("Game saved successfully... The game will now exit.");
                return true;
            }
            catch (Exception ex)
            {
                LineHelpers.PrintLineWithContinue("Error Message: " + ex.ToString());
                LineHelpers.PrintLineWithContinue("\nFailed to save game please try again.");
                return false;
            }
        }
        // make this return player or error if there is no player
        public static Player Load()
        {
            string json;
            try
            {
                json = File.ReadAllText(LocalSavePath);
                var results = JsonConvert.DeserializeObject<SaveModel>(json);
                return GetPlayerHelper(results);
            }
            catch
            {
                return null;
            }
        }

        // This grabs the proper init type
        private static Player GetPlayerHelper(SaveModel playerInformation)
        {
            switch (playerInformation.Type)
            {
                case "Human":
                    switch (playerInformation.Class)
                    {
                        case "Warrior":
                            return new HumanWarrior(playerInformation);
                        case "Wizard":
                            return new HumanWizard(playerInformation);
                        case "Rogue":
                            return new HumanRogue(playerInformation);
                    }
                    break;
                case "Dwarf":
                    switch (playerInformation.Class)
                    {
                        case "Warrior":
                            return new DwarfWarrior(playerInformation);
                        case "Wizard":
                            return new DwarfWizard(playerInformation);
                        case "Rogue":
                            return new DwarfRogue(playerInformation);
                    }
                    break;
                case "Elf":
                    switch (playerInformation.Class)
                    {
                        case "Warrior":
                            return new ElfWarrior(playerInformation);
                        case "Wizard":
                            return new ElfWizard(playerInformation);
                        case "Rogue":
                            return new ElfRogue(playerInformation);
                    }
                    break;
            }
            return null;
        }

        // Simple statement for game deletion on starting a new game
        public static bool DeleteSave()
        {
            if (String.IsNullOrEmpty(File.ReadAllText(LocalSavePath)))
            {
                return true;
            }
            LineHelpers.PrintLine("Are you sure you want to delete your save?");
            LineHelpers.PrintLine("1. Yes");
            LineHelpers.PrintLine("2. No");

            var input = LineHelpers.ReadInputNumber(new int[] { 1, 2 });
            
            if(input == 1)
            {
                try
                {
                    File.WriteAllText(LocalSavePath, "");
                    LineHelpers.PrintLineWithContinue("Save game deleted...");
                    return true;
                }
                catch
                {
                    LineHelpers.PrintLineWithContinue("Error, save was not deleted...");
                    return false;
                }
            }
            else
            {
                LineHelpers.PrintLineWithContinue("Save was not deleted...");
                return false;
            }
        }
    }
}
