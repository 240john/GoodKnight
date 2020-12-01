using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class AdamantArmor : Armor
    {
		private int _DamageDeflected = 10;
		public int DamageDeflected
		{
			get
			{
				return _DamageDeflected;
			}
		}
	}
}
