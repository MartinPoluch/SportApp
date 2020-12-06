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
using ICommand = SportApp.command.ICommand;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for CommandButton.xaml
	/// </summary>
	public partial class CommandButton : UserControl {

		public ICommand Command { get; set; }

		public string CommandName {
			get {
				return Command.GetName();
			}
		}

		public CommandButton() {
			InitializeComponent();
			DataContext = this;
		}

		private void ButtonAction(object sender, RoutedEventArgs e) {
			Command.Execute();
		}
	}
}
