using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	public class Command
	{
		public bool isCode;
		public String commandName;
		public dynamic commandClass;
		CommandLoaders.CommandSettings commandSettings;
		public Command(String argCommandName,bool argIsCode,dynamic argCommandClass)
		{
			commandName = argCommandName;
			isCode = argIsCode;
			commandClass = argCommandName;
		}
	}
}
