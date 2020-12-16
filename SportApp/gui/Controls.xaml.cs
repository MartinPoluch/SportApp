using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SportApp.command;
using SportApp.command.dataGenerator;
using UserControl = System.Windows.Controls.UserControl;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for Controls.xaml
	/// </summary>
	public partial class Controls : UserControl {

		public Controls() {
			DataContext = this;
			InitializeComponent();

			CreateTeam.Command = new CreateTeamCommand();
			UpdateTeam.Command = new UpdateTeamCommand();
			DeleteTeam.Command = new DeleteTeamCommand();
			DeleteAllTeams.Command = new DeleteAllTeamsCommand();
			GenerateTeams.Command = new GenerateTeamsCommand();

			GenerateReport.Command = new GenerateReportCommand();
			ImportSport.Command = new ImportSportCommand();
			ExportSport.Command = new ExportSportCommand();

			ShowLogs.Command = new ShowLogsCommand();
		}
	}
}
