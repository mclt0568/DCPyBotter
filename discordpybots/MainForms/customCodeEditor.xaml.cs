using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace discordpybots.MainForms
{
	/// <summary>
	/// Interaction logic for customCodeEditor.xaml
	/// </summary>
	public partial class customCodeEditor : UserControl
	{
		CommandLoaders.CommandByCodes commandClass;
		commandEditor editor;
		String header = "";
		public customCodeEditor(CommandLoaders.CommandByCodes argCommandClass, commandEditor argEditor)
		{
			editor = argEditor;
			commandClass = argCommandClass;
			InitializeComponent();
			updateToForm();
		}
		public void updateToClass()
		{
			editor.command.commandClass.code = codingIDE.Text;
		}
		public void setHeader(String argHeader)
		{
			header = argHeader;
			functionDefinitionLines.Text = argHeader;
		}
		public void updateToForm()
		{
			setHeader("@client.command()\nasync def {0}(ctx,{1}):\n");
			int splitted = commandClass.code.Split('\n').Count();
			String indexing="";
			for (int i = 0; i < splitted; i++)indexing += "\n" + (i+1).ToString();
			indexing = indexing.Substring(1);
			lineNumberBox.Text = indexing;
		}
		//event handler
		private void codeTextChange(object sender, TextChangedEventArgs e)
		{
			updateToClass();
			updateToForm();
		}
	}
}
