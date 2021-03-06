﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.OtherClasses.Things
{
    public class Armor : Thing
    {
        public int ArmorRating { get; }

        public Armor(string name, string description, int armorRating, int cost)
        {
            Name = name;
            ArmorRating = armorRating;
            Description = description;
            Cost = cost;
        }
    }
}
