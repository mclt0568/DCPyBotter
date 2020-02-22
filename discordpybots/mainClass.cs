using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace discordpybots
{
	class MainClass
	{
		ProjectLoaders.ProjectLoader_Debug debugProject = new ProjectLoaders.ProjectLoader_Debug();
		ProjectLoaders.Project openedProject;
		public void loadProject()
		{
			openedProject = debugProject.load();
		}
		public ProjectLoaders.Project getProject()
		{
			return openedProject;
		}
		public List<TreeViewItem> getCommandTreeViewItemByName(List<CommandLoaders.Command> command)
		{
			List<TreeViewItem> treeViewItemList = new List<TreeViewItem>();
			foreach (CommandLoaders.Command singleCommand in command)
			{
				ContextMenu ctxMenu = new ContextMenu();
				MenuItem removeCmdItem = new MenuItem();
				removeCmdItem.Header = "Remove";
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
	}
}
