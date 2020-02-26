using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordpybots.ProjectLoaders
{
	public class Settings
	{
		public bool showConsoleOutput;
		public String pythonPath;
		public String botToken;
		public String botPrefix;
		public Settings()
		{
			pythonPath = "python";
			showConsoleOutput = false;
			botToken = "";
			botPrefix = ">";
		}
		public void setpythonPath(String path)
		{
			if (pythonPath == "(Use Default)")
			{
				pythonPath = "python";
				return;
			}
			pythonPath = path;
		}
		public void updateForm()
		{
			;
		}
	}
}
