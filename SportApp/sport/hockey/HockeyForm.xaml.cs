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
using SportApp.sport.general;

namespace SportApp.sport.hockey {
	/// <summary>
	/// Interaction logic for HockeyForm.xaml
	/// </summary>
	public partial class HockeyForm : Window, ITeamForm {

		private bool _isSaved;

		public HockeyForm() {
			InitializeComponent();
			_isSaved = false;
		}

		public void showForm() {
			ShowDialog();
		}

		public bool ValidInputs() {
			try {
				if (GetTeamForm().ValidInputs()) {
					NewTeam();
					return true;
				}

				return false;
			}
			catch (Exception e) {
				return false;
			}
		}

		public bool IsSaved() {
			return _isSaved;
		}

		public Team NewTeam() {
			HockeyTeam team = new HockeyTeam(GetTeamForm().NewTeam()) {
				WinsInOvertime = int.Parse(WinsOtInput.Text),
				LosesInOvertime = int.Parse(LosesOtInput.Text)
			};
			return team;
		}

		private HockeyTeam TestHockeyTeam() {
			return new HockeyTeam {
				Name = "Test team",
				Matches = 1,
				Wins = 2,
				Loses = 3,
				Points = 4,
				Score = new Score(){Plus = 5, Minus = 6},
				WinsInOvertime = 7,
				LosesInOvertime = 8
			};
		}

		public ITeamForm GetTeamForm() {
			return TeamForm;
		}

		public void SaveTeam(object sender, RoutedEventArgs e) {
			_isSaved = true;
			Close();
		}
	}
}
