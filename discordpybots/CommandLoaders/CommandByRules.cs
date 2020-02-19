using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	class CommandByRules
	{
		String commandName;
		int argCount;
		List<ReplyRule> rules;
		public CommandByRules(String name,int ArgCount)
		{
			commandName = name;
			argCount = ArgCount;
		}
		public void addRule(ReplyRule rule)
		{
			rules.Append(rule);
		}
		public void removeRule(int index)
		{
			rules.RemoveAt(index);
		}
		public String generatePythonCode(char tabChar)
		{

			return "";
		}
	}
}
