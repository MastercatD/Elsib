using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDataBase.Models
{
		public class Material
		{
				public Material(int code, string name, int cost) 
				{
						this._code = code;
						this._name = name;
						this._cost = cost;
				}
				private int _code;
				private string _name;
				private int _cost;
				public int code { get => _code; }
				public string name { get => _name; }
				public int cost { get => _cost; }

		}
}
