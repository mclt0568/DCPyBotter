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
		public ProjectLoaders.Project openedProject;
		Dialogs.NewItem newItemDialoge;
		CommandLoaders.CommandLoader cmdLoader = new CommandLoaders.CommandLoader();
		CustomClassLoaders.CustomClassLoader ccLoader = new CustomClassLoaders.CustomClassLoader();
		ImportModuleLoaders.ImportModuleLoader imLoader = new ImportModuleLoaders.ImportModuleLoader();
		dynamic currentPanel;
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
				//treeview item
				TreeViewItem element = new TreeViewItem();
				element.Header = singleCommand.commandName;
				element.MouseLeftButtonUp += (s, e) => { loadCommandPanel(singleCommand.commandName); };

				//context menu
				ContextMenu ctxMenu = new ContextMenu();
				MenuItem removeCmdItem = new MenuItem();
				removeCmdItem.Header = "Remove";
				removeCmdItem.Click += (s, e) => { removeCommandFromProject(singleCommand.commandName); };
				ctxMenu.Items.Add(removeCmdItem);
				element.ContextMenu = ctxMenu;

				//add item
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
				ContextMenu ctxMenu = new ContextMenu();
				MenuItem removeCcItem = new MenuItem();
				removeCcItem.Header = "Remove";
				removeCcItem.Click += (s, e) => { removeCustomClassFromProject(singleClass.className); };
				ctxMenu.Items.Add(removeCcItem);
				element.ContextMenu = ctxMenu;
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
				ContextMenu ctxMenu = new ContextMenu();
				MenuItem removeImItem = new MenuItem();
				removeImItem.Header = "Remove";
				removeImItem.Click += (s, e) => { removeImportedModuleFromProject(singleModule.moduleName); };
				ctxMenu.Items.Add(removeImItem);
				element.ContextMenu = ctxMenu;
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
		public void updateListView()
		{
			cmdTreeView.Items.Clear();
			ccTreeView.Items.Clear();
			ilTreeView.Items.Clear();
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
				ilTreeView.Items.Add(i);
			}
		}
		
		//Panels
		public void loadCommandPanel(String name)
		{
			currentPanel = new FormControls.CommandForm(this,name);
			currentPanel.loadPanel();
		}
		// Remove Functions
		private void removeCommandFromProject(string name)
		{
			int index = cmdLoader.getIndexByName(name, openedProject.commandList);
			openedProject.commandList.RemoveAt(index);
			updateListView();
		}
		private void removeCustomClassFromProject(string name)
		{
			int index = ccLoader.getIndexByName(name, openedProject.customClassList);
			openedProject.customClassList.RemoveAt(index);
			updateListView();
		}
		private void removeImportedModuleFromProject(string name)
		{
			int index = imLoader.getIndexByName(name, openedProject.importedModuleList);
			openedProject.importedModuleList.RemoveAt(index);
			updateListView();
		}

		// Debug Events
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			initProject();
			updateListView();	
		}
		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			Utils.IntUtils iutil = new Utils.IntUtils();
			MessageBox.Show(TestText.Text);
			try
			{
				int a = Int16.Parse(TestText.Text);
				MessageBox.Show(a.ToString());

			}
			catch (System.FormatException) {
				MessageBox.Show("err");
			}

			//MessageBox.Show(openedProject.commandList[index].commandClass.code);
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
		
	}
}
