﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class LeatherArmor : Armor
    {
		private int _DamageDeflected = 1;
		public int DamageDeflected
		{
			get
			{
				return _DamageDeflected;
			}
		}
		public override void calculateDeflection(int luck, bool isHeavy)
		{
			_DamageDeflected = _DamageDeflected * (luck);
			if (isHeavy == true)
				_DamageDeflected = _DamageDeflected * 2;
		}
	}
}
