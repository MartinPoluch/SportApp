using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.hockey {

	public class HockeyFactory : SportFactory {

		private static readonly Sport _hockey = new Hockey();

		public HockeyFactory() {
		}

		public override Sport GetSport() {
			return _hockey;
		}

		public override ITeamForm CreateTeamForm() {
			return new HockeyForm();
		}

		public override TeamGenerator CreateTeamGenerator() {
			return new HockeyTeamGenerator();
		}

		public override ReportDescription CreateReportDescription() {
			return new ReportDescription(
				_hockey,
				new[] {"Name", "Matches", "Wins", "Loses", "Points", "Score", "Wins OT", "Loses OT"});
		}
	}
}
