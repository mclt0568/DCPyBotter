using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ImportModuleLoaders
{
	class ImportedModules
	{
		public String moduleName;
		public List<SubModules> subModuleList = new List<SubModules>();
		public ImportedModules(String argModuleName)
		{
			moduleName = argModuleName;
			subModuleList.Add(new SubModules(argModuleName));
		}
	}
}
