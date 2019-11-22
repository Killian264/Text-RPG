using System;
using System.Collections.Generic;
using System.Text;

namespace Killian_Text_RPG
{
	public interface IWarrior
	{
		int BlockChance
		{
			get;
			set;
		}

		List<Spell> ClassSpells
		{
			get;
			set;
		}

        List<Spell> LevelUpWarrior();
    }
}
