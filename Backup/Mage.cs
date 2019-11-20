using System;
using System.Collections.Generic;
using System.Text;

namespace Text RPG
{
	public interface Mage
	{
		List Spells
		{
			get;
			set;
		}

		int SpellPoints
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
