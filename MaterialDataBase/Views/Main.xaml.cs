
using MaterialDataBase.Models;
using MaterialDataBase.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MaterialDataBase.Views
{
		public partial class Main : Window
		{
				public Main()
				{
						InitializeComponent();
						MainViewModel mainViewModel = new MainViewModel();
						this.DataContext = mainViewModel;
				}

				private void Button_Click(object sender, RoutedEventArgs e)
				{
						this.Close();
				}


		}
}
