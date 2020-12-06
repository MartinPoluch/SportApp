using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class GenerateReportCommand : ICommand {

		public void Execute() {
			throw new NotImplementedException();
		}

		public string GetName() {
			return "Generate Report";
		}
	}
}
