using System;
using System.Collections.Generic;
using System.Text;

namespace Text RPG
{
	public interface Rogue
	{
		int CritChance
		{
			get;
			set;
		}

		List ClassSpells
		{
			get;
			set;
		}
	}
}
