using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.sport.general {

	public abstract class TeamGenerator {

		private Random _random;

		protected TeamGenerator() {
			_random = new Random();
		}

		public HashSet<string> TeamNames { get; set; }

		public abstract Team RandomTeam(string name);

		protected int RandomNumber(int min, int max) {
			return _random.Next(min, max + 1);
		}
	}
}
