using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.football {
	public class FootballFactory : SportFactory{

		public override Sport GetSport() {
			string info = "TODO write some info about football";
			return new Football("Football", info);
		}

		public override ITeamForm CreateTeamForm() {
			throw new NotImplementedException();
		}

		public override TeamGenerator CreateTeamGenerator() {
			throw new NotImplementedException();
		}

		public override ReportDescription CreateReportDescription() {
			throw new NotImplementedException();
		}
	}
}
