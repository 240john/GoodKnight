using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class Armor : Equipment
	{
		private int _DamageDeflected;
		public int DamageDeflected
        {
			get
			{
				return _DamageDeflected;
			}
		}
	}
}
