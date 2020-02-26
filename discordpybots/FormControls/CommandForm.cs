using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.FormControls
{
	public class CommandForm
	{
		MainForms.commandEditor mainPanel;
		ProjectLoaders.Project project;
		MainWindow mainWindow;
		CommandLoaders.Command command;
		CommandLoaders.CommandLoader cmdLoader = new CommandLoaders.CommandLoader();
		public CommandForm(MainWindow argMainWindow,String commandName)
		{
			mainWindow = argMainWindow;
			project = mainWindow.openedProject;
			int index = cmdLoader.getIndexByName(commandName, project.commandList);
			command = project.commandList[index];
			mainPanel = new MainForms.commandEditor(this, command);
		}
		public void loadPanel()
		{
			mainPanel.init();
			mainWindow.maindock.Children.Clear();
			mainWindow.maindock.Children.Add(mainPanel);
		}
		public void updateProject() { }
	}
}
