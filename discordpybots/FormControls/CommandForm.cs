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
		dynamic editArea;
		public CommandForm(MainWindow argMainWindow,String commandName)
		{
			mainPanel = new MainForms.commandEditor(this);
			mainWindow = argMainWindow;
			project = mainWindow.openedProject;
			int index = cmdLoader.getIndexByName(commandName, project.commandList);
			command = project.commandList[index];
		}
		public void loadPanel()
		{
			switch (command.isCode)
			{
				case true:
					editArea = new MainForms.customCodeEditor();
					break;
				case false:
					editArea = new MainForms.customClassEditor();
					break;
			}
			mainWindow.maindock.Children.Clear();
			command.commandName = command.commandName;
			mainPanel.editArea.Children.Add(editArea);
			mainWindow.maindock.Children.Add(mainPanel);
		}
		public void updateProject() { }
	}
}
