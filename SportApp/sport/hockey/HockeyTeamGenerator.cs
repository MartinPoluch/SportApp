using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.hockey {
	public class HockeyTeamGenerator : TeamGenerator {

		private static readonly int PointsForWin = 3;
		private static readonly int PointsForWinInOt = 2;
		private static readonly int PointsForLoseInOt = 1;

		public HockeyTeamGenerator() {
			TeamNames = new HashSet<string>() {
				"Carolina Hurricanes", "Columbus Blue Jackets", "New Jersey Devils", "New York Islanders",
				"New York Rangers", "Philadelphia Flyers", "Pittsburgh Penguins", "Washington Capitals",
				"Boston Bruins", "Buffalo Sabres", "Detroit Red Wings", "Florida Panthers", 
				"Montreal Canadiens", "Ottawa Senators", "Tampa Bay Lightning", "Toronto Maple Leafs", 
				"Chicago Blackhawks", "Colorado Avalanche", "Dallas Stars", "Minnesota Wild",
				"Nashville Predators", "St. Louis Blues", "Winnipeg Jets", "Anaheim Ducks",
				"Arizona Coyotes", "Calgary Flames", "Edmonton Oilers", "Los Angeles Kings",
				"San Jose Sharks", "Vancouver Canucks", "Vegas Golden Knights",
			};
		}

		public override Team RandomTeam(string name) {
			int matches = RandomNumber(78, 82);

			int allWins = RandomNumber(0, matches);
			int winsInOt = RandomNumber(0, allWins / 2);
			int wins = allWins - winsInOt;

			int allLoses = matches - allWins;
			int losesInOt = RandomNumber(0, allLoses / 2);
			int loses = allLoses - losesInOt;

			int points = (wins * PointsForWin) + (winsInOt * PointsForWinInOt) + (losesInOt + PointsForLoseInOt);
			Score score = new Score() {
				Plus = RandomNumber(150, 250),
				Minus = RandomNumber(170, 240),
			};

			return new HockeyTeam() {
				Name = name,
				Matches = matches,
				Wins = wins,
				Loses = loses,
				Points = points,
				Score = score,
				WinsInOvertime = winsInOt,
				LosesInOvertime = losesInOt
			};
		}
	}
}
