using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class Weapons : Equipment
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
