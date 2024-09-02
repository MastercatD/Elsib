using MaterialDataBase.Commands;
using MaterialDataBase.Models;
using MaterialDataBase.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaterialDataBase.ViewModel
{
		public class AddMaterialViewModel
		{
				AddMaterial window;
				public ICommand AddMaterialCommand { get; set; }
				public ICommand CloseMaterialWinCommand { get; set; }

				public int code { get; set; } = MainViewModel.codeCounter;
				public string name { get; set; }
				public int cost { get; set; }

				public AddMaterialViewModel()
				{
						AddMaterialCommand = new RelayCommand(AddMaterial, CanAddMaterial);
						CloseMaterialWinCommand = new RelayCommand(CloseMaterialWindow, CanCloseMaterialWindow);

				}

				private bool CanCloseMaterialWindow(object obj)
				{
						return true;
				}

				private void CloseMaterialWindow(object obj)
				{
						MainViewModel.CloseMaterialWin();
				}

				private bool CanAddMaterial(object obj)
				{
						return true;
				}

				private void AddMaterial(object obj)
				{

						MaterialManager.AddMaterial(new Material(code, name, cost));
						MainViewModel.CloseMaterialWin();



				}
		}
}
