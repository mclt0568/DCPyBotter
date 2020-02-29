using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ProjectLoaders
{
	public class Project
	{
		public List<CommandLoaders.Command> commandList;
		public List<CustomClassLoaders.CustomClass> customClassList;
		public List<ImportModuleLoaders.ImportedModules> importedModuleList;
		public String botName;
		public Settings settings;
		public Project(String argBotName, List<CommandLoaders.Command> argCommandList, List<CustomClassLoaders.CustomClass> argCustomClassList, List<ImportModuleLoaders.ImportedModules> argImportModuleLoader,Settings argSettings)
		{
			botName = argBotName;
			settings = argSettings;
			commandList = argCommandList;
			customClassList = argCustomClassList;
			importedModuleList = argImportModuleLoader;
		}
	}
}
