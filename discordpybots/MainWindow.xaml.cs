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
namespace discordpybots
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ProjectLoaders.ProjectLoader_Debug debugProject = new ProjectLoaders.ProjectLoader_Debug();
		TextBox codebox = new TextBox();
		ProjectLoaders.Project openedProject;
		Dialogs.NewItem newItemDialoge;
		CommandLoaders.CommandLoader cmdLoader = new CommandLoaders.CommandLoader();
		public MainWindow()
		{
			InitializeComponent();
			initProject();
		}
		
		//treeview getter
		public List<TreeViewItem> getCommandTreeViewItemByName(List<CommandLoaders.Command> command)
		{
			List<TreeViewItem> treeViewItemList = new List<TreeViewItem>();
			foreach (CommandLoaders.Command singleCommand in command)
			{
				ContextMenu ctxMenu = new ContextMenu();
				MenuItem removeCmdItem = new MenuItem();
				removeCmdItem.Header = "Remove";
				removeCmdItem.Click += (s, e) => { removeCommandFromProject(singleCommand.commandName); };
				ctxMenu.Items.Add(removeCmdItem);
				TreeViewItem element = new TreeViewItem();
				element.Header = singleCommand.commandName;
				element.ContextMenu = ctxMenu;
				treeViewItemList.Add(element);
			}
			return treeViewItemList;
		}
		public List<TreeViewItem> getCustomClassTreeViewItemByName(List<CustomClassLoaders.CustomClass> customClass)
		{
			List<TreeViewItem> treeViewItemList = new List<TreeViewItem>();
			foreach (CustomClassLoaders.CustomClass singleClass in customClass)
			{
				TreeViewItem element = new TreeViewItem();
				element.Header = singleClass.className;
				treeViewItemList.Add(element);
			}
			return treeViewItemList;
		}
		public List<TreeViewItem> getImportedModuleTreeViewItemByName(List<ImportModuleLoaders.ImportedModules> importedModules)
		{
			List<TreeViewItem> treeViewItemList = new List<TreeViewItem>();
			foreach (ImportModuleLoaders.ImportedModules singleModule in importedModules)
			{
				TreeViewItem element = new TreeViewItem();
				element.Header = singleModule.moduleName;
				treeViewItemList.Add(element);
			}
			return treeViewItemList;
		}

		// MainMethodes
		void initNewItemWindow()
		{
			newItemDialoge = new Dialogs.NewItem();
		}
		void initProject()
		{
			openedProject = debugProject.load();
		}
		void updateListView()
		{
			cmdTreeView.Items.Clear();
			List<TreeViewItem> treeViewItemsCmd = getCommandTreeViewItemByName(openedProject.commandList);
			List<TreeViewItem> treeViewItemsCcClass = getCustomClassTreeViewItemByName(openedProject.customClassList);
			List<TreeViewItem> treeViewItemsImportedModule = getImportedModuleTreeViewItemByName(openedProject.importedModuleList);
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

		// Debug Events
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			initProject();
			updateListView();	
		}
		private void Button_Click2(object sender, RoutedEventArgs e)
		{
		}

		// Events
		//  -  Project Explorer
		private void newButton(object sender, RoutedEventArgs e)
		{
			initNewItemWindow();
			dynamic newItem = newItemDialoge.getItemInfo();
			if (newItem.GetType() != 1.GetType()) {
				if (newItem.GetType() == typeof(CommandLoaders.Command))
					openedProject.commandList.Add(newItem);
				else if (newItem.GetType() == typeof(CustomClassLoaders.CustomClass))
					openedProject.customClassList.Add(newItem);
				else openedProject.importedModuleList.Add(newItem);
				updateListView();
			}
		}
		private void removeCommandFromProject(string name)
		{
			int index = cmdLoader.getCommandIndexByName(name,openedProject.commandList);
			openedProject.commandList.RemoveAt(index);
			updateListView();
		}
	}
}
