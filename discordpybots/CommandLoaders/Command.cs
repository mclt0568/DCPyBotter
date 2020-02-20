using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	class Command
	{
		int type;
		String commandName;
		dynamic commandClass;
		CommandLoaders.CommandSettings commandSettings;
		public Command(String argCommandName,int argType,dynamic argCommandClass)
		{
			commandName = argCommandName;
			type = argType;
			commandClass = argCommandName;
		}
	}
}
