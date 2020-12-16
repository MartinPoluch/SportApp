using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class ImportSportCommand : ICommand {
		public void Execute() {
			throw new NotImplementedException("Import is not implemented.");
		}

		public string GetName() {
			return "Import Sport";
		}
	}
}
