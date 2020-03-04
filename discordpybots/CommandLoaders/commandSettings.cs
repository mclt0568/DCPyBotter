using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	public class CommandSettings
	{
		public int argumentCount;
		public CommandSettings(int argArgCount)
		{
			argumentCount = argArgCount;
		}
	}
}
