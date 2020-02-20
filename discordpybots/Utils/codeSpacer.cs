using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.Utils
{
	class CodeSpacer
	{
		public string space(char tabChar,String code)
		{
			List<String> brokenCode = code.Split('\n').ToList();
			String afterSpaces = "";
			foreach (String i in brokenCode)
			{
				afterSpaces += (tabChar.ToString() + i + "\n");
			}
			return (afterSpaces);
		}
	}
}
