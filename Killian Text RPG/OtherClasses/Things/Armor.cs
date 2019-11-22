using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.OtherClasses.Things
{
    public class Armor : Thing
    {
        public int ArmorRating { get; }

        public Armor(string name, string description, int armorRating, int id, int cost)
        {
            Name = name;
            this.ID = id;
            ArmorRating = armorRating;
            Description = description;
            Cost = cost;
        }
    }
}
