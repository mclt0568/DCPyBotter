using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	class CommandSettings
	{
		String commandName;
		int argumentCount;
		public CommandSettings(String argName, int argArgCount)
		{
			commandName = argName;
			argumentCount = argArgCount;
		}
	}
}
