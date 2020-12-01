using System;
using System.Collections.Generic;
using System.Text;

namespace GoodKnight
{
	public class Enemy
	{
		static string _Name;
		private int _Damage;
		private int _Health;
		string _Drop;
		private bool _IsDrop;
		private int _Luck;

		public Enemy(int luck) //parametered constructor
		{
			this._Luck = luck;
		}

		public Enemy() // paramterless constructor
		{
		}
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

		public void RandomizeDrop()
		{
			throw new NotImplementedException();
		}

		public void CalculateDamage()
		{
			throw new NotImplementedException();
		}

		public void CalculateHealth()
		{
			throw new NotImplementedException();
		}

		public static string RandomizeEnemy(int luck)
		{
			int num = new Random().Next(0, 5); //used for random enemy
			num = num + luck;
			if (num > 5)
				num = 5;
			switch (num)
			{
				case 1:
					_Name = "a Dragon";
					return _Name;
				case 2:
					_Name = "a Bear";
					return _Name;
				case 3:
					_Name = "a Giant Toad";
					return _Name;
				case 4:
					_Name = "a Spider";
					return _Name;
				case 5:
					_Name = "some Bees";
					return _Name;
			}
			return _Name;
		}
	}
}
