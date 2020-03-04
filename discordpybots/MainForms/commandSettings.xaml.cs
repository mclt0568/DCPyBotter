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
using System.Windows.Shapes;

namespace discordpybots.MainForms
{
	/// <summary>
	/// Interaction logic for commandSettings.xaml
	/// </summary>
	public partial class commandSettings : Window
	{
		protected bool isOk = false;
		CommandLoaders.Command command;
		MainWindow mainWindow;
		public commandSettings(CommandLoaders.Command cmd, MainWindow argMainWindow)
		{
			command = cmd;
			mainWindow = argMainWindow;
			InitializeComponent();
		}
		public void init()
		{
			argCountTextbox.Text = command.commandSetting.argumentCount.ToString();
			commandNameTextbox.Text = command.commandName;
		}
		void okButton(object s, RoutedEventArgs e)
		{
			try
			{
				int a = Int16.Parse(argCountTextbox.Text);
				if ((a < -2 )||(a>255)){
					MessageBox.Show(argCountTextbox.Text + " is not a valid number 1");
				}
				else { 
				isOk = true;
				Close();
				}
			}
			catch
			{
				MessageBox.Show(argCountTextbox.Text + " is not a valid number");
			}
		}
		void cancelButton(object s ,RoutedEventArgs e)
		{
			isOk = false;
			Close();
		}
		public void set(){
			ShowDialog();
			switch (isOk)
			{
				case true:
					command.commandName = commandNameTextbox.Text;
					command.commandSetting.argumentCount = Int16.Parse(argCountTextbox.Text);
					mainWindow.updateListView();
					mainWindow.loadCommandPanel(command.commandName);
					break;
				case false:
					break;
			}
		}
	}
}
