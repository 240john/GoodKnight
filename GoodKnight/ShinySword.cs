using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class ShinySword : Weapons
    {
		private int _DamageBoost = 15;

		public int DamageBoost
		{
			get
			{
				return _DamageBoost;
			}
		}
	}
}
