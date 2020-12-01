using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodKnight
{
    class IronArmor : Armor
    {
		private int _DamageDeflected = 3;
		public int DamageDeflected
		{
			get
			{
				return _DamageDeflected;
			}
		}
	}
}
