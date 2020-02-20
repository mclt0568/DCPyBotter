using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ProjectLoaders
{
	
	class Project
	{
		List<CommandLoaders.Command> commandList = new List<CommandLoaders.Command>();
		List<CustomClassLoaders.CustomClass> customClassList = new List<CustomClassLoaders.CustomClass>();
		public Project()
		{

		}
	}
}
