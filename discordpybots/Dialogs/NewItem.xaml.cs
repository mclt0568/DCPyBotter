using System;
using System.Collections.Generic;
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

namespace discordpybots.Dialogs
{
	/// <summary>
	/// Interaction logic for NewItem.xaml
	/// </summary>
	public partial class NewItem : Window
	{
		bool confirmed = false;
		public NewItem()
		{
			InitializeComponent();
		}
		public void cancelButton(object s,RoutedEventArgs e)
		{
			confirmed = false;
			Close();
		}
		public void okButton(object s,RoutedEventArgs e)
		{

			if (itemSelector.Text != "" && itemName.Text.Trim() != "") { Close(); confirmed = true; }
			else MessageBox.Show("Item Type or Name/Module Name cannot be empty.");
		}
		public dynamic getItemInfo()
		{
			ShowDialog();
			if (confirmed) {
				if (itemSelector.SelectedIndex == 0)
					return new CommandLoaders.Command(itemName.Text, false, new CommandLoaders.CommandByRules(itemName.Text, 1));

				else if (itemSelector.SelectedIndex == 1)
					return new ImportModuleLoaders.ImportedModules(itemName.Text.Trim());
				else return new CustomClassLoaders.CustomClass(itemName.Text.Trim());
			}
			else return -1;
		}

		private void ItemSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (itemSelector.SelectedIndex)
			{
				case 0:
					newIcon.Source = new BitmapImage(new Uri(@"\Resources\Items\NewCommand.png", UriKind.Relative));
					break;
				case 1:
					newIcon.Source = new BitmapImage(new Uri(@"\Resources\Items\ImportModule.png",UriKind.Relative));
					break;
				case 2:
					newIcon.Source = new BitmapImage(new Uri(@"\Resources\Items\NewClass.png", UriKind.Relative));
					break;
			}
		}
	}
}
