using System;
using System.Collections.Generic;
using System.Text;

namespace Text RPG
{
	public interface Warrior
	{
		int BlockChance
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
