using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ImportModuleLoaders
{
	public class ImportModuleLoader
	{
		public ImportModuleLoader() {}
		public int getIndexByName(String name, List<ImportedModules> importedModules)
		{
			int index = 0;
			foreach (ImportedModules i in importedModules)
			{
				if (i.moduleName == name)
				{
					return index;
				}
				index++;
			}
			return -1;
		}
	}
}
