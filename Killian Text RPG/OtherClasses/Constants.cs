using Killian_Text_RPG.OtherClasses.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.Helpers
{
    public static class Constants
    {
        // these are all constants for different functions and other stuff
        // This could be saved in a json but its easier to have it here
        //Spell(string name, string type, int damage, int cost, int level, string modifier, int modifierPercent, string useString, string description)
        //{
        //    Name = name;
        //    Type = type;
        //    Damage = damage;
        //    Cost = cost;
        //    Level = level;
        //    Modifier = modifier;
        //    ModifierPercent = modifierPercent;
        //    UseString = useString;
        //    Description = description;
        //}
        public static List<Spell> WizardSpells = new List<Spell>()
        {
            // The enemy class takes these parameters in order
            /* 
            1. Name 
            2. Type
            3. Damage 
            4. Cost
            5. Level
            6. Modifier
            7. Modifier Percent
            8. UseString (The (attack type) (and it))
            11. [Unrequired] Description
            */
        };
        public static List<Spell> WarriorSpells = new List<Spell>()
        {
            // The enemy class takes these parameters in order
            /* 
            1. Name 
            2. Type
            3. Damage 
            4. Cost
            5. Level
            6. Modifier
            7. Modifier Percent
            8. UseString (The (attack type) (and it))
            11. [Unrequired] Description
            */
        };
        public static List<Spell> RogueSpells = new List<Spell>()
        {
            // The enemy class takes these parameters in order
            /* 
            1. Name 
            2. Type
            3. Damage 
            4. Cost
            5. Level
            6. Modifier
            7. Modifier Percent
            8. UseString (The (attack type) (and it))
            11. [Unrequired] Description
            */
        };



        public static List<Enemy> Enemies = new List<Enemy>()
        {
            // The enemy class takes these parameters in order
            /* 
            1. Name 
            2. Enemy type 
            3. Health 
            4. Level 
            5. Attack Damage 
            6. Defence 
            7. Reward Gold 
            8. Attack String Format (The (enemy name) (attack type) (and it))
            9. Encounter String (Any)
            10. Death String (Any)
            11. [Unrequired] Description


            Health, Level, AD, Def, Gold
            15,       1,    5,  5,   20, 

            */

            new Enemy("Slime", "Small blob.",
                15,1,5,5,20, 
                "The slime shoots a small bit of acidic slime towards you and it ", 
                "Out of the darkness you a small creature move into the light it's a slime.", 
                "The slime flattens until it breaks apart and expands into a puddle..."),

            new Enemy("Large Rat", "Rat.",
                20,1,6,1,20,
                "The rat rushes and slams into you before swinging its claws to attack and it ",
                "A dark mass in the shape of a wolf moves out from the shadows. A large rat appears.",
                "The rat topples over and lays still..."),

            new Enemy("Kobold", "Small Humanoid",
                23, 2, 5, 5, 20, 
                "The kobold swings with its club and it ", 
                "Out of the darkness you a small creature move into the light. A kobold appears with a club in its hand. ", 
                "The kobold falls backwards and twitches before laying still..."),

            new Enemy("Bandit", "Humanoid",
                23, 3, 9, 8, 40,
                "The bandit swings with his sword and ",
                "A man yells for help and you rush towards him. Upon making it to him the man turns with a bloody sword and smiles...",
                "The bandit turns and runs dropping his coin purse..."),

            new Enemy("Zombie", "Humanoid",
                35, 3, 11, 2, 40,
                "The zombie swings with his sword and ",
                "You hear a throaty growl from the darkness and see a the shape of a human. A zombie walks otu of the darkness.",
                "The zombie falls and dies."),

           new Enemy("Kobold Warlord", "Small Humanoid",
                23, 4, 5, 5, 20,
                "The kobold swings with its greatsword and it ",
                "Out of the darkness you a creature move into the light. A kobold warlord appears with a greatsword in its hand. ",
                "The kobold falls backwards and twitches before laying still..."),

            new Enemy("Unarmed Gnoll", "Gnoll",
                35, 5, 10, 9, 60,
                "The Gnoll swings and ",
                "A large troll emerges from the darkness",
                "The troll dies and you rush over and light it on fire before it gets back up."),

            new Enemy("Small Troll", "Troll",
                40, 6, 13, 12, 70,
                "The troll swings its mighty hammer and ",
                "A small troll emerges from the darkness",
                "The troll falls and slams into the ground in a cloud of dust. You move around it and check that its dead before moving on."),

            new Enemy("Gnoll", "Gnoll",
                42, 7, 14, 11, 80,
                "The Gnoll swings and ",
                "A large gnoll emerges from the darkness",
                "The gnoll dies and you rush over and light it on fire before it gets back up."),

            new Enemy("Troll", "Troll",
                40, 8, 16, 16, 100,
                "The troll swings its mighty hammer and ",
                "A large troll emerges from the darkness",
                "The troll falls and slams into the ground in a cloud of dust. You move around it and check that its dead before moving on."),

            new Enemy("Troll Warlord", "Troll",
                60, 9, 16, 20, 300,
                "The troll swings its mighty greataxe and ",
                "You walk into a huge room with tables covered in bodies of humans and creatures alike. You see a large throne at the end of the room with a Troll the size of an elephant standing next to it. It turns to you and smiles. \"Lunch is here\" ",
                "The great troll falls onto one knee and you run forward and slam its head into its greataxe killing it."),

        };

        public static List<Armor> Armors = new List<Armor>()
        {
            // The Armor class takes these parameters in order
            /* 
            1. Name 
            2. Description
            3. ArmorRating
            5. Cost
            */
            new Armor("Cloth Armor", "A thick multilayered cloth breastpiece.", 2, 30),
            new Armor("Leather Armor", "A simple leather breastpiece with strong threads holding it together.", 4, 60),
            new Armor("Stutted Leather Armor", "A tough and stiff leather breastpiece with reinforced with iron rivots.", 6, 90),
            new Armor("Platemail", "A thick piece of cloth armor with plates inside.", 8, 150),
            new Armor("Chainmail", "A large and heavy chestplate of interlinked chains.", 10, 300),
            new Armor("Half Plate", "Plates of metal that cover most of the wearers body.", 12, 400),
            new Armor("Plate", "Plates of metal that covers the wearers body.", 16, 500),
        };
        public static List<Weapon> Weapons = new List<Weapon>()
        {
            // The Armor class takes these parameters in order
            /* 
            1. Name 
            2. Description
            3. minDamage
            4. maxDamage
            5. Id (should be deleted later probably)
            6. Cost
            */
            new Weapon("Club", "A thick piece of reinforced wood.", 1, 5, 30),
            new Weapon("Dagger", "A small hilted dagger with a sharp edge.", 3, 4, 40),
            new Weapon("Quarterstaff", "A large rod of reinforced wood and metal.", 4, 7, 90),
            new Weapon("ShortSword", "A weapon with a thick metal hilt with a larged and pointed end.", 5, 6, 120),
            new Weapon("Sword", "A weapon with a thick metal hilt with a larged and pointed end.", 6, 7, 150),
            new Weapon("Glaive", "A weapon with a thick metal hilt with a larged and pointed end.", 7, 8, 180),
            new Weapon("Greatsword", "A weapon with a thick metal hilt with a larged and pointed end.", 9, 9, 200),
        };
        public static List<Consumable> Consumables = new List<Consumable>()
        {
            // The Armor class takes these parameters in order
            /* 
            1. Name 
            2. Description
            3. Heal Amount
            5. Cost
            */
            new Consumable("Potion", "A bottle of ever-flowing red liquid with a slight glow.", 10, 15),
            new Consumable("Large Potion", "A large bottle of ever-flowing red liquid with a slight glow.", 20, 30),
            new Consumable("Potion + 1", "A bottle of ever-flowing red liquid with a bright glow.", 30, 60),
            new Consumable("Large Potion + 1", "A large bottle of ever-flowing red liquid with a bright glow.", 40, 120),
        };

    }
}
