using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	class CommandLoader
	{
		public CommandLoader(){}
		public int getCommandIndexByName(String name,List<Command> commands){
			int index = 0;
			foreach (Command i in commands)
			{
				if (i.commandName == name)
				{
					return index;
				}
				index++;
			}
			return -1;
		}
	}
}
