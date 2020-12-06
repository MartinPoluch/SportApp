using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.hockey {

	public class HockeyFactory : SportFactory {

		private static readonly Sport Hockey = new Hockey(
			"Hockey", 
			"Some info about hockey");

		public HockeyFactory() {
		}

		public override Sport GetSport() {
			return Hockey;
		}

		public override ITeamForm CreateTeamForm() {
			return new HockeyForm();
		}

	}
}
