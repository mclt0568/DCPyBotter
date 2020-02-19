using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.Utils
{
	class IntUtils
	{
		int i = 0;
		public int convertFromString(String intString)
		{
			if (!Int32.TryParse(intString, out i))
			{
				i = -1;
			}
			return i;
		}
	}
}
