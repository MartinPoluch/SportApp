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
		private bool _update;

		public HockeyForm() {
			InitializeComponent();
			_isSaved = false;
			_update = false;
		}

		public void showForm() {
			ShowDialog();
		}

		public bool ValidInputs(bool update) {
			try {
				if (GetTeamForm().ValidInputs(update)) {
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
			HockeyTeam team = new HockeyTeam {
				Name = "Test team",
				Matches = 1,
				Wins = 2,
				Loses = 3,
				Points = 4,
				Score = new Score() {Plus = 5, Minus = 6},
				WinsInOvertime = 7,
				LosesInOvertime = 8
			};
			return (_isSaved) ? team : null;
		}

		public ITeamForm GetTeamForm() {
			return TeamForm;
		}

		public void SaveTeam(object sender, RoutedEventArgs e) {
			try {
				if (ValidInputs(_update)) {
					_isSaved = true;
					Close();
				}
				else {
					MessageBox.Show("Invalid inputs!", "Wrong input", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
			catch (Exception exception) {
				MessageBox.Show(exception.Message, "Wrong input", MessageBoxButton.OK, MessageBoxImage.Error);

			}
		}

		public void fillForm(Team team) {
			_update = true;
			GetTeamForm().fillForm(team);
			HockeyTeam hockeyTeam = (HockeyTeam)team;
			WinsOtInput.Text = hockeyTeam.WinsInOvertime.ToString();
			LosesOtInput.Text = hockeyTeam.LosesInOvertime.ToString();
		}
	}
}
