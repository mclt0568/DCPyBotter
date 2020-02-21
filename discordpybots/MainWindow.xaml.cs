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
		public MainWindow()
		{
			InitializeComponent();
		}
		void initProject()
		{
			mainClass.loadProject();
			openedProject = mainClass.getProject();
		}
		void Button_Click(object sender, RoutedEventArgs e)
		{
			initProject();
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
		void Button_Click2(object sender, RoutedEventArgs e)
		{

		}

		private void newButton_Click(object sender, EventArgs e)
		{
			newElementButton.ContextMenu = new ContextMenu();
			MenuItem ctxItem = new MenuItem();
			ctxItem.Header = "test";
			newElementButton.ContextMenu.Items.Add(ctxItem);
			newElementButton.ContextMenu.
		}
	}
}
