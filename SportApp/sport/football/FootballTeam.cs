using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.sport.football {

	public class FootballTeam : Team {

		public int Draws { get; set; }

		public FootballTeam() {
		}

		public FootballTeam(Team team) : base(team) {
		}

		public override List<string> PropertyValues() {
			List<string> properties = base.PropertyValues();
			properties.Add(Draws.ToString());
			return properties;
		}
	}
}
