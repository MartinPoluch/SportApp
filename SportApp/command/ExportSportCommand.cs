using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;

namespace SportApp.command {
	public class ExportSportCommand : ICommand {
		public void Execute() {
			LoggerFacade.LogWarning("Export is not implemented.");
		}

		public string GetName() {
			return "Export SPort";
		}
	}
}
