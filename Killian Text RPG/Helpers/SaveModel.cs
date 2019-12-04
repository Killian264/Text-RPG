using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    // This is a model that will be used on Load to grab all class information
    public class SaveModel
    {
        public int Constitution { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int BaseAttackDamage { get; set; }
        public int Defence { get; set; }
        public int CurrentHealth { get; set; }
        public string Type { get; set; }
        public int Gold { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int ExpNextLevel { get; set; }
        public int ExpCurrent { get; set; }
        public string Class { get; set; }

        // Weapons, Armors, Items
        public Weapon CurrentWeapon { get; set; }
        public Armor CurrentArmor { get; set; }

        public List<Weapon> Weapons { get; set; }

        public List<Armor> Armor { get; set; }
        public List<Consumable> Consumables { get; set; }

        // Class specific stats

        public int SpellPoints { get; set; }
        public int BlockChance { get; set; }
        public int CritChance { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Spell> ClassSpells { get; set; }
    }
}

//{
//  "Armor": [],
//  "BaseAttackDamage": 8,
//  "Class": "Wizard",
//  "ClassSpells": [],
//  "Constitution": 20,
//  "Consumables": [],
//  "CurrentArmor": {
//    "ArmorRating": 1,
//    "Name": "Wool Shirt",
//    "ID": 0,
//    "Description": "A wool shirt.",
//    "Cost": 1
//  },
//  "CurrentHealth": 20,
//  "CurrentWeapon": {
//    "MinDamage": 1,
//    "MaxDamage": 1,
//    "Name": "Unarmed",
//    "ID": 0,
//    "Description": "No weapon.",
//    "Cost": 1
//  },
//  "Defence": 3,
//  "Dexterity": 13,
//  "ExpCurrent": 0,
//  "ExpNextLevel": 1000,
//  "Gold": 20,
//  "Intelligence": 24,
//  "Level": 1,
//  "Name": "Killian",
//  "SpellPoints": 10,
//  "Spells": [],
//  "Strength": 13,
//  "Type": "Elf",
//  "Weapons": []
//}
