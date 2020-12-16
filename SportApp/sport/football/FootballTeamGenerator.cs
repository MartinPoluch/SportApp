using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.football {
	public class FootballTeamGenerator : TeamGenerator {

		private static readonly int PointsForWin = 3;
		private static readonly int PointsForDraw = 1;

		public FootballTeamGenerator() {
			TeamNames = new HashSet<string>() {
				"Real Sociedad", "Atletico Madrid", "Real Madrid", "Villarreal",
				"FC Sevilla", "Granada CF", "Cádiz", "FC Barcelona", "Celta Vigo",
				"Betis Sevilla", "SD Eibar", "Valencia", "Athletic Bilbao", "Elche",
				"Alaves", "Getafe", "Valladolid", "Levante", "Huesca", "CA Osasuna",
			};
		}

		public override Team RandomTeam(string name) {
			int matches = RandomNumber(35, 38);
			int wins = RandomNumber(0, matches);
			int loses = RandomNumber(0, matches - wins);
			int draws = matches - wins - loses;
			int points = (wins * PointsForWin) + (draws * PointsForDraw);
			Score score = new Score() {
				Plus = RandomNumber(30, 60),
				Minus = RandomNumber(30, 50)
			};
			return new FootballTeam() {
				Name = name,
				Matches = matches,
				Wins = wins,
				Loses = loses,
				Draws = draws,
				Points = points,
				Score = score
			};
		}
	}
}
