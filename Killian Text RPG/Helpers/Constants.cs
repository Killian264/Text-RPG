﻿using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    public static class Constants
    {
        public static List<Enemy> Enemies = new List<Enemy>()
        {
            new Enemy("Kobald", "Small Humanoid",12, 1, 10, 5, 20),
        };
        public static List<Armor> Armors = new List<Armor>()
        {
            new Armor("Cloth Armor", "A thick multilayered cloth breastpiece.", 2, 1, 30),
            new Armor("Leather Armor", "A simple leather breastpiece with strong threads holding it together.", 4, 2, 60),
            new Armor("Stutted Leather Armor", "A tough and stiff leather breastpiece with reinforced with iron rivots.", 6, 3, 90),
            new Armor("Platemail", "A thick piece of cloth armor with plates inside.", 8, 4, 150),
            new Armor("Chainmail", "A large and heavy chestplate of interlinked chains.", 10, 5, 300),
            new Armor("Half Plate", "Plates of metal that cover most of the wearers body.", 12, 6, 400),
            new Armor("Plate", "Plates of metal that covers the wearers body.", 16, 7, 500),
        };
        public static List<Weapon> Weapons = new List<Weapon>()
        {
            new Weapon("Club", "A thick piece of reinforced wood.", 1, 5, 1, 30),
            new Weapon("Dagger", "A small hilted dagger with a sharp edge.", 3, 4, 2, 40),
            new Weapon("Quarterstaff", "A large rod of reinforced wood and metal.", 4, 7, 3, 90),
            new Weapon("Mace", "A weapon with a thick metal hilt with a larged and pointed end.", 5, 6, 4, 120),
        };
        public static List<Consumable> Consumables = new List<Consumable>()
        {
            new Consumable("Potion", "A bottle of glowing red liquid that moves on its own.", 10, 1, 30),
        };

        //public static int test()
        //{
        //    Armor armor = new Armor("Chainmail", "A large and heavy chestplate of interlinked chains.", 10, 1, 200);
        //    armor.
        //    return 1;
        //}
    }
}
