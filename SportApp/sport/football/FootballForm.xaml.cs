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

namespace SportApp.sport.football {
	/// <summary>
	/// Interaction logic for FootballForm.xaml
	/// </summary>
	public partial class FootballForm : Window, ITeamForm {

		private bool _isSaved;
		private bool _update;

		public FootballForm() {
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

		private ITeamForm GetTeamForm() {
			return TeamForm;
		}

		public bool IsSaved() {
			return _isSaved;
		}

		public Team NewTeam() {
			return new FootballTeam(GetTeamForm().NewTeam()) {
				Draws = int.Parse(Draws.Text),
			};
		}

		public void fillForm(Team team) {
			_update = true;
			GetTeamForm().fillForm(team);
			FootballTeam footballTeam = (FootballTeam)team;
			Draws.Text = footballTeam.Draws.ToString();
		}

		private void SaveTeam(object sender, RoutedEventArgs e) {
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
	}
}
