using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.football {
	public class FootballFactory : SportFactory{

		private static readonly Football _football = new Football();

		public override Sport GetSport() {
			return _football;
		}

		public override ITeamForm CreateTeamForm() {
			return new FootballForm();
		}

		public override TeamGenerator CreateTeamGenerator() {
			return new FootballTeamGenerator();
		}

		public override ReportDescription CreateReportDescription() {
			return new ReportDescription(
				_football,
				new[] { "Name", "Matches", "Wins", "Loses", "Points", "Score", "Draws" });
		}
	}
}
