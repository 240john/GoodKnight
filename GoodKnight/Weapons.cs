using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	abstract class Weapons : Equipment
	{
		private int _DamageBoost;

		public int DamageBoost
        {
			get
			{
				return _DamageBoost;
			}
		}
	}
}
