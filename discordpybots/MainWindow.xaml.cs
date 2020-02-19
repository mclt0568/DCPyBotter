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
using discordpybots.CommandLoaders;
namespace discordpybots
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		TextBox codebox = new TextBox();
		public MainWindow()
		{
			InitializeComponent();
		}
		void Button_Click(object sender, RoutedEventArgs e)
		{
			codebox.AcceptsReturn = true;
			maindock.Children.Add(codebox);
		}
		void Button_Click2(object sender, RoutedEventArgs e)
		{
			CommandByCodes command = new CommandByCodes("test",3);
			command.addCode(codebox.Text);
			MessageBox.Show(command.generatePythonCode('\t'));
		}
	}
}
