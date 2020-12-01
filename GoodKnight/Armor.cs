using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	abstract class Armor : Equipment
	{
		private int _DamageDeflected;
		public int DamageDeflected
        {
			get
			{
				return _DamageDeflected;
			}
		}
		public virtual void calculateDeflection(int luck, bool isHeavy)
        {
			_DamageDeflected = _DamageDeflected * (luck - 1);
        }
	}
}
