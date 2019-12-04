using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public interface IWizard
	{
		int SpellPoints
		{
			get;
			set;
		}

		List<Spell> ClassSpells
		{
			get;
			set;
		}

        List<Spell> LevelUpMage();
	}
}
