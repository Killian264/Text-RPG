using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    public static class Constants
    {
        public static List<Enemy> Enemies = new List<Enemy>()
        {
            new Enemy("Kobold", "Small Humanoid",12, 1, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold2", "Small Humanoid",12, 2, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold3", "Small Humanoid",12, 3, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold4", "Small Humanoid",12, 4, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold5", "Small Humanoid",12, 5, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold6", "Small Humanoid",12, 6, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold7", "Small Humanoid",12, 7, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold8", "Small Humanoid",12, 8, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold9", "Small Humanoid",12, 9, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
            new Enemy("Kobold", "Small Humanoid",12, 10, 10, 5, 20, "The kobold swings with its club and it ", "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", "The kobold falls backwards and twitches before laying still."),
        };
        // Code would need to be refactored for id's over 8 I could use letters if im lazy -- only issue if user choice
        // 0 is for none and here because these are used for selling could be added with no issues
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
            new Weapon("ShortSword", "A weapon with a thick metal hilt with a larged and pointed end.", 5, 6, 4, 120),
            new Weapon("Sword", "A weapon with a thick metal hilt with a larged and pointed end.", 6, 7, 5, 150),
            new Weapon("Glaive", "A weapon with a thick metal hilt with a larged and pointed end.", 7, 8, 6, 180),
            new Weapon("Greatsword", "A weapon with a thick metal hilt with a larged and pointed end.", 9, 9, 7, 200),
        };
        public static List<Consumable> Consumables = new List<Consumable>()
        {
            new Consumable("Potion", "A bottle of ever-flowing red liquid with a slight glow.", 10, 1, 15),
            new Consumable("Large Potion", "A large bottle of ever-flowing red liquid with a slight glow.", 20, 2, 30),
            new Consumable("Potion + 1", "A bottle of ever-flowing red liquid with a bright glow.", 30, 3, 60),
            new Consumable("Large Potion + 1", "A large bottle of ever-flowing red liquid with a bright glow.", 40, 4, 120),
        };

    }
}
