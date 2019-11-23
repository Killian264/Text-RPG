using Killian_Text_RPG.Helpers;
using Killian_Text_RPG.OutputInterfaces;
using System;
using System.Collections.Generic;

namespace Killian_Text_RPG.Events
{
    public class CharacterBuilder
    {
        public static Player BuildCharacter()
        {
            Interface.TempInterface();
            LineHelpers.PrintLine("Enter your name:");

            var name = LineHelpers.ReadLine();

            string[] races = { "Human", "Elf", "Dwarf"};
            // possibly add stat info later
            Interface.TempInterface(name);
            LineHelpers.PrintLine("Choose Race");
            LineHelpers.PrintLine("1. Human - +1 Defence +1 Strength -");
            LineHelpers.PrintLine("2. Elf - +2 Intelligence -1 Strength +1 Dexterity - ");
            LineHelpers.PrintLine("3. Dwarf - +2 Defence +2 Strength -1 Dexterity -");


            var race = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3 });
            race--;
            Interface.TempInterface(name, races[race]);

            string[] charClasses = new string[3] { "Warrior", "Wizard", "Rogue" };

            LineHelpers.PrintLine("Choose Class");
            LineHelpers.PrintLine("1. Fighter");
            LineHelpers.PrintLine("2. Wizard");
            LineHelpers.PrintLine("3. Rogue");

            var charClass = LineHelpers.ReadInputNumber(new int[] { 1, 2, 3 });
            charClass--;
            Interface.TempInterface(name, races[race], charClasses[charClass]);

            var character = CharacterReturnHelper(name, races[race], charClasses[charClass]);

            Interface.BasicInterface(character);

            LineHelpers.AnyKeyToContinue();

            return character;
        }

        private static Player CharacterReturnHelper(string name, string race, string userClass)
        {
            switch(race){
                case "Human":
                    switch (userClass)
                    {
                        case "Warrior":
                            return new HumanWarrior(name);
                        case "Wizard":
                            return new HumanWizard(name);
                        case "Rogue":
                            return new HumanRogue(name);
                    }
                    break;
                case "Dwarf":
                    switch (userClass)
                    {
                        case "Warrior":
                            return new DwarfWarrior(name);
                        case "Wizard":
                            return new DwarfWizard(name);
                        case "Rogue":
                            return new DwarfRogue(name);
                    }
                    break;
                case "Elf":
                    switch (userClass)
                    {
                        case "Warrior":
                            return new ElfWarrior(name);
                        case "Wizard":
                            return new ElfWizard(name);
                        case "Rogue":
                            return new ElfRogue(name);
                    }
                    break;
            }
            return null;
        }
    }
}
