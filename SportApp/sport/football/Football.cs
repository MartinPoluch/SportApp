using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.sport.football {

	public class Football : Sport {

		private static readonly string DefaultName = "La Liga";
		private static readonly string DefaulInfo =
			"La Liga is the men's top professional football division of the Spanish football league system." +
			" Administered by the Liga Nacional de Fútbol Profesional, is contested by 20 teams, " +
			"with the three lowest-placed teams at the end of each season relegated to the Segunda División " +
			"and replaced by the top two teams and a play-off winner in that division.\n" +
			"A total of 62 teams have competed in La Liga since its inception. " +
			"Nine teams have been crowned champions, with Real Madrid winning the title a record 34 times and FC Barcelona 26 times. " +
			"During the 1940s Valencia, Atlético Madrid and Barcelona emerged as the strongest clubs, winning several titles. " +
			"Real Madrid and Barcelona dominated the championship in the 1950s, each winning four La Liga titles during the decade. " +
			"During the 1960s and 1970s Real Madrid dominated La Liga, winning 14 titles, with Atlético Madrid winning four. " +
			"During the 1980s and 1990s Real Madrid were prominent in La Liga, " +
			"but the Basque clubs of Athletic Bilbao and Real Sociedad had their share of success, " +
			"each winning two Liga titles. From the 1990s onward, Barcelona have dominated La Liga winning 16 titles up to date." +
			" Although Real Madrid has been prominent, winning nine titles, " +
			"La Liga has also seen other champions, including Atlético Madrid, Valencia, and Deportivo La Coruña.";

		public Football(string name, string info) : base(name, info) {
		}

		public Football() : base(DefaultName, DefaulInfo) {
		}
	}
}
