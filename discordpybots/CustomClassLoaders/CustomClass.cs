using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CustomClassLoaders
{
	public class CustomClass
	{
		public String className;
		public int constructorVariableCount;
		public String code;
		public CustomClass(String name)
		{
			className = name;
		}
	}
}
