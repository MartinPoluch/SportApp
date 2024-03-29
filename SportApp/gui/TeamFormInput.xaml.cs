﻿using System;
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
using SportApp.command;
using SportApp.sport.general;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for TeamFormInput.xaml
	/// </summary>
	public partial class TeamFormInput : UserControl, ITeamForm {
		public TeamFormInput() {
			InitializeComponent();
		}

		public void showForm() {
			// not implemented
		}

		public bool ValidInputs(bool update) {
			try {
				NewTeam();
				Sport sport = SportFactory.GetInstance().GetSport();
				if (NameInput.Text.Length == 0) {
					return false;
				}

				return update || (sport.GetTeam(NameInput.Text) == null);
			}
			catch (Exception e) {
				return false;
			}
		}

		public bool IsSaved() {
			return true;
		}

		private Score ParseScore() {
			string[] splitScore = ScoreInput.Text.Split(':');
			if (splitScore.Length == 2) {
				return new Score() {
					Plus = int.Parse(splitScore[0]),
					Minus = int.Parse(splitScore[1])
				};
			}
			else {
				throw new ArgumentException();
			}
			
		}

		public Team NewTeam() {
			return new Team {
				Name = NameInput.Text,
				Matches = int.Parse(MatchesInput.Text),
				Wins = int.Parse(WinsInput.Text),
				Loses = int.Parse(LosesInput.Text),
				Points = int.Parse(PointsInput.Text),
				Score = ParseScore()
			};
		}

		public void fillForm(Team team) {
			NameInput.IsReadOnly = true;
			NameInput.Text = team.Name;
			MatchesInput.Text = team.Matches.ToString();
			WinsInput.Text = team.Wins.ToString();
			LosesInput.Text = team.Loses.ToString();
			PointsInput.Text = team.Points.ToString();
			ScoreInput.Text = team.Score.ToString();
		}
	}
}
