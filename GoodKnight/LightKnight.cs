using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class LightKnight : Character
	{
		private int _Damage = 30;
		private int _Health = 25;
		private bool _MagicAbility = false;
		private int _Luck;
		public int Damage
		{
			set
			{
				_Damage = value;
			}
			get
			{
				return _Damage;
			}
		}

		public int Health
		{
			set
			{
				_Health = value;
			}
			get
			{
				return _Health;
			}
		}

		public bool MagicAbility
		{
			set
			{
				_MagicAbility = value;
			}
			get
			{
				return _MagicAbility;
			}
		}

		public int Luck
		{
			set
			{
				_Luck = value;
			}
			get
			{
				return _Luck;
			}
		}

		public LightKnight()
        {

        }
		public LightKnight(int luck) // parametered constructor
		{
			if (luck == 1)
				this._Luck = 3;
			else if (luck == 3)
				this._Luck = 1;
			else
				this.Luck = luck;
		}
	}
}
