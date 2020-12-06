using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.sport.general {
	public class Score {

		public int Plus { get; set; }
		public int Minus { get; set; }

		public override string ToString() {
			return$"{Plus}:{Minus}";
		}
	}
}
