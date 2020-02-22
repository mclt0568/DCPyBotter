using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ImportModuleLoaders
{
	public class SubModules
	{
		String submodulePath;
		String importedAs;
		bool HasCustomName;
		public SubModules(String argSubmodulePath)
		{
			submodulePath = argSubmodulePath;
		}
		public void setHasCustomName(bool setTo, String argCustomeName = "")
		{
			HasCustomName = setTo;
			importedAs = argCustomeName;
		}
	}
}
