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
				TreeViewItem element = new TreeViewItem();
				element.Header = singleCommand.commandName;
				treeViewItemList.Add(element);
			}
			return treeViewItemList;
		}
	}
}
