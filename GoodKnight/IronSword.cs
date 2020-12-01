using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class IronSword : Weapons
    {
		private int _DamageBoost = 5;

		public int DamageBoost
		{
			get
			{
				return _DamageBoost;
			}
		}
	}
}
