using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MaterialDataBase.Commands;
using MaterialDataBase.Models;
using MaterialDataBase.Views;

namespace MaterialDataBase.ViewModel
{
		public class MainViewModel
		{
				static private AddMaterial _addMaterialWin;
				static public AddMaterial addMaterialWin { get => _addMaterialWin; }
				private int _selectedIndex;
				public int selectedIndex { get => _selectedIndex; set => _selectedIndex = value; }
				public ObservableCollection<Material> Materials { get; set; }

				public ICommand ShowWindowCommand { get; set; }
				public ICommand CloseCommand { get; set; }
				public ICommand RemoveCommand { get; set; }


				public MainViewModel()
				{
						Materials = MaterialManager.GetMaterial();
						ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
						RemoveCommand = new RelayCommand(Remove, CanRemove);
				}

				private bool CanRemove(object obj)
				{
						if (selectedIndex == -1) return false;
						return true;
				}

				private void Remove(object obj)
				{
						MaterialManager.RemoveMaterial(selectedIndex);
				}

				private bool CanShowWindow(object obj)
				{
						return true;
				}

				private void ShowWindow(object obj)
				{
						if (addMaterialWin == null)
						{
								var mainWindow = obj as Window;

								_addMaterialWin = new AddMaterial();
								_addMaterialWin.Owner = mainWindow;
								_addMaterialWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
						}
						
								_addMaterialWin.Show();
					

				}
		}
}
