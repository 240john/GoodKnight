using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class GiantToad : Enemy
	{
		private int _Health = 30;
		private int _Damage = 5;
		private bool _IsDrop = true;
		private string _Drop = "Iron Sword";
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
		public string Drop
		{
			set
			{
				_Drop = value;
			}
			get
			{
				return _Drop;
			}
		}
	}
}
