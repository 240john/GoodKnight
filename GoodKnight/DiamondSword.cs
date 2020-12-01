using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class DiamondSword : Weapons
    {
		private int _DamageBoost = 20;

		public int DamageBoost
		{
			get
			{
			return _DamageBoost;
			}
		}
	}
}
