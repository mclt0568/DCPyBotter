using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.CustomClassLoaders
{
	class CustomClassLoader
	{
		public CustomClassLoader(){} 
		public int getIndexByName(String name, List<CustomClass> customClasses)
		{
			int index = 0;
			foreach (CustomClass i in customClasses)
			{
				if (i.className == name)
				{
					return index;
				}
				index++;
			}
			return -1;
		}
	}
}
