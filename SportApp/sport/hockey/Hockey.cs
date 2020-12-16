using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.hockey {

	public class Hockey : Sport {

		private static readonly string DefaultName = "NHL";
		private static readonly string DefaulInfo = 
			"The National Hockey League (NHL) is a professional ice hockey league in North America, " +
			"currently comprising 31 teams: 24 in the United States and 7 in Canada. " +
			"The NHL is considered to be the premier professional ice hockey league in the world, " +
			"and one of the major professional sports leagues in the United States and Canada. " +
			"The Stanley Cup, the oldest professional sports trophy in North America, " +
			"is awarded annually to the league playoff champion at the end of each season.";

		public Hockey(string name, string info) : base(name, info) {

		}

		public Hockey() : base(DefaultName, DefaulInfo) {
		}
	}
}
