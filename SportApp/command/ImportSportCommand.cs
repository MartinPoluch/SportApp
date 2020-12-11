using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class ImportSportCommand : ICommand {
		public void Execute() {
			//TODO
		}

		public string GetName() {
			return "Import Sport";
		}
	}
}
