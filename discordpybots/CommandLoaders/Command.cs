using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	class Command
	{
		bool isCode;
		String commandName;
		dynamic commandClass;
		CommandLoaders.CommandSettings commandSettings;
		public Command(String argCommandName,bool argIsCode,dynamic argCommandClass)
		{
			commandName = argCommandName;
			isCode = argIsCode;
			commandClass = argCommandName;
		}
	}
}
