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
				private static int _code = 2;
				private static ObservableCollection<Material> _databaseMaterials = new ObservableCollection<Material>() { new Material(0, "сталь", 1000), new Material(1, "алюминий", 500) };

				public static ObservableCollection<Material> GetMaterial()
				{
						return _databaseMaterials;

				}

				public static int GetCode() {  return _code; }
				public static void AddMaterial(Material material)
				{
						_databaseMaterials.Add(material);
						_code++;
				}
				public static void RemoveMaterial(int index)
				{
						_databaseMaterials.RemoveAt(index);
				}
		}
}
