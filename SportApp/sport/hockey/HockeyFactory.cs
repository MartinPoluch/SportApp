using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.hockey {

	public class HockeyFactory : SportFactory {

		private static readonly Sport Hockey = new Hockey(
			"NHL", 
			"Some info about hockey");

		public HockeyFactory() {
		}

		public override Sport GetSport() {
			return Hockey;
		}

		public override ITeamForm CreateTeamForm() {
			return new HockeyForm();
		}

		public override TeamGenerator CreateTeamGenerator() {
			return new HockeyTeamGenerator();
		}

		public override ReportDescription CreateReportDescription() {
			return new ReportDescription(
				Hockey,
				new[] {"Name", "Matches", "Wins", "Loses", "Points", "Score", "Wins OT", "Loses OT"});
		}
	}
}
