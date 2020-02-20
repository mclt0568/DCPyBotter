using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using discordpybots;

namespace discordpybots.ProjectLoaders
{
	class ProjectLoader_Debug
	{
		public ProjectLoader_Debug(){;}
		public Project load()
		{
			List<CommandLoaders.Command> cmdList = new List<CommandLoaders.Command>();
			List<CustomClassLoaders.CustomClass> ccList = new List<CustomClassLoaders.CustomClass>();
			List<ImportModuleLoaders.ImportedModules> imList = new List<ImportModuleLoaders.ImportedModules>();

			CommandLoaders.CommandByCodes cmdBC = new CommandLoaders.CommandByCodes("test", 1);
			CommandLoaders.Command cmd = new CommandLoaders.Command("Hi", true, cmdBC);
			cmdList.Add(cmd);

			Settings settings = new Settings();
			settings.botPrefix = ">";
			settings.showConsoleOutput = true;

			Project proj = new Project("helloworld",cmdList,ccList,imList,settings);
			return proj;
		}
	}
}
