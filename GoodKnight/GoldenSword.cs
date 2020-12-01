using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class GoldenSword : Weapons
    {
		private int _DamageBoost = 4;

		public int DamageBoost
		{
			get
			{
				return _DamageBoost;
			}
		}
	}
}
