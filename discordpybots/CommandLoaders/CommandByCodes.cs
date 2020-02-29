using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CommandLoaders
{
	public class CommandByCodes
	{
		String commandName;
		int argCount;
		public String code = "";
		public CommandByCodes(String name, int args)
		{
			commandName = name;
			argCount = args;
		}
		public void addCode(String codeLine)
		{
			code += codeLine;
		}
		public void clearCode()
		{
			code = "";
		}
		public String generatePythonCode(char tabChar)
		{
			String codeHeader = "@client.command()\nasync def {0}(ctx,{1}):\n";
			String argsString = "";
			for (int i=0; i< argCount;i++)
			{
				argsString += String.Format(",arg{0}",i);
			}
			argsString = argsString.Substring(1);
			codeHeader = String.Format(codeHeader,commandName,argsString);
			List<String> brokenCode = code.Split('\n').ToList();
			String afterSpaces = "";
			foreach (String i in brokenCode)
			{
				afterSpaces += (tabChar.ToString() + i + "\n");
			}
			return (codeHeader+"\n"+afterSpaces);
		}
	}
}
