using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG.OtherClasses
{
    public abstract class Thing
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public int Cost { get; protected set; }

    }
}
