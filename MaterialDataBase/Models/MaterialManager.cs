using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDataBase.Models
{
		public class MaterialManager
		{
				public static ObservableCollection<Material> _databaseUsers = new ObservableCollection<Material>() { new Material(0, "сталь", 1000), new Material(1, "алюминий", 500) };

				public static ObservableCollection<Material> GetMaterial()
				{
						return _databaseUsers;

				}


				public static void AddMaterial(Material material)
				{
						_databaseUsers.Add(material);
				}
				public static void RemoveMaterial(int index)
				{
						_databaseUsers.RemoveAt(index);
				}
		}
}
