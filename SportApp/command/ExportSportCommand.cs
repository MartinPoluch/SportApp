using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class ExportSportCommand : ICommand {
		public void Execute() {
			//TODO
		}

		public string GetName() {
			return "Export SPort";
		}
	}
}
