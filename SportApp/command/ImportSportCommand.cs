using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;

namespace SportApp.command {
	public class ImportSportCommand : ICommand {
		public void Execute() {
			LoggerFacade.LogWarning("Import is not implemented.");
		}

		public string GetName() {
			return "Import Sport";
		}
	}
}
