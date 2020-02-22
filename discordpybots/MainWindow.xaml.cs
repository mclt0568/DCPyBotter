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
using System.Windows.Navigation;
using System.Windows.Shapes;
using discordpybots.CommandLoaders;
namespace discordpybots
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		TextBox codebox = new TextBox();
		MainClass mainClass = new MainClass();
		ProjectLoaders.Project openedProject;
		Dialogs.NewItem newItemDialoge;
		public MainWindow()
		{
			InitializeComponent();
		}
		void initNewItemWindow()
		{
			newItemDialoge = new Dialogs.NewItem();
		}
		void initProject()
		{
			mainClass.loadProject();
			openedProject = mainClass.getProject();
		}
		void updateListView()
		{
			cmdTreeView.Items.Clear();
			List<TreeViewItem> treeViewItemsCmd = mainClass.getCommandTreeViewItemByName(openedProject.commandList);
			List<TreeViewItem> treeViewItemsCcClass = mainClass.getCustomClassTreeViewItemByName(openedProject.customClassList);
			List<TreeViewItem> treeViewItemsImportedModule = mainClass.getImportedModuleTreeViewItemByName(openedProject.importedModuleList);
			foreach (TreeViewItem i in treeViewItemsCmd)
			{
				cmdTreeView.Items.Add(i);
			}
			foreach (TreeViewItem i in treeViewItemsCcClass)
			{
				ccTreeView.Items.Add(i);
			}
			foreach (TreeViewItem i in treeViewItemsImportedModule)
			{
				ilTreeViel.Items.Add(i);
			}
		}
		void Button_Click(object sender, RoutedEventArgs e)
		{
			initProject();
			updateListView();	
		}
		void Button_Click2(object sender, RoutedEventArgs e)
		{
		}
		private void newButton_Click(object sender, RoutedEventArgs e)
		{
			initNewItemWindow();
			dynamic newItem = newItemDialoge.getItemInfo();
			if (newItem.GetType() != 1.GetType()) {
				MessageBox.Show("1");
				if (newItem.GetType() == typeof(CommandLoaders.Command))
					openedProject.commandList.Add(newItem);
				else if (newItem.GetType() == typeof(CustomClassLoaders.CustomClass))
					openedProject.customClassList.Add(newItem);
				else openedProject.importedModuleList.Add(newItem);
				updateListView();
			}
		}
	}
}
