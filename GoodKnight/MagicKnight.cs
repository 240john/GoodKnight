using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class MagicKnight : Character
	{
		private int _Damage = 10;
		private int _Health = 20;
		private bool _MagicAbility = true;
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
		public int Resistance
		{
			set
			{
				_Resistance = value;
			}
			get
			{
				return _Resistance;
			}
		}
		public MagicKnight()
        {

        }
		public MagicKnight(int luck) // parametered constructor
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
