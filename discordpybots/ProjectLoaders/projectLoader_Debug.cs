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
			cmdList.Add(new CommandLoaders.Command("Hi", true, new CommandLoaders.CommandByCodes("test", 1)));
			cmdList.Add(new CommandLoaders.Command("He", true, new CommandLoaders.CommandByCodes("test", 1)));
			cmdList.Add(new CommandLoaders.Command("Ho", true, new CommandLoaders.CommandByCodes("test", 1)));

			ccList.Add(new CustomClassLoaders.CustomClass("sys1"));
			ccList.Add(new CustomClassLoaders.CustomClass("sys2"));
			ccList.Add(new CustomClassLoaders.CustomClass("sys3"));

			imList.Add(new ImportModuleLoaders.ImportedModules("sys"));

			Settings settings = new Settings();
			settings.botPrefix = ">";
			settings.showConsoleOutput = true;

			Project proj = new Project("helloworld",cmdList,ccList,imList,settings);
			return proj;
		}
	}
}
