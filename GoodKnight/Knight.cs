using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class Knight : Enemy
	{
		private int _Health = 100;
		private int _Damage = 15;
		private bool _IsDrop = false;
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
		public bool IsDrop
		{
			set
			{
				_IsDrop = value;
			}
			get
			{
				return _IsDrop;
			}
		}
	}
}
