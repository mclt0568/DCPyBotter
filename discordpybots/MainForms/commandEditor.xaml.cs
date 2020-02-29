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
using discordpybots.FormControls;

namespace discordpybots.MainForms
{
	/// <summary>
	/// Interaction logic for commandEditor.xaml
	/// </summary>
	public partial class commandEditor : UserControl
	{
		CommandForm parentControl;
		public CommandLoaders.Command command;
		dynamic editAreaClass;
		public commandEditor(CommandForm argControl,CommandLoaders.Command argCommand)
		{
			parentControl = argControl;
			command = argCommand;
			InitializeComponent();
		}
		private void setupSubForm()
		{
			switch (command.isCode)
			{
				case true:
					editAreaClass = new MainForms.customCodeEditor(command.commandClass, this);
					break;
				case false:
					editAreaClass = new MainForms.customReplyEditor();
					break;
			}
			editArea.Children.Clear();
			editArea.Children.Add(editAreaClass);
		}
		public void init() {
			commandNameCaption.Text = command.commandName;
			setupSubForm();
		}
		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
