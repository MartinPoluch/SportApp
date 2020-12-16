using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.gui;

namespace SportApp.command {
	public class ShowLogsCommand : ICommand {

		public void Execute() {
			AllLogs.GetInstance().Show();
		}

		public string GetName() {
			return "Show logs";
		}
	}
}
