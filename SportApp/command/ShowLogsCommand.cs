using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;
using SportApp.gui;

namespace SportApp.command {
	public class ShowLogsCommand : ICommand {

		public void Execute() {
			try {
				AllLogs.GetInstance().Show();
			}
			catch (Exception exception) {
				LoggerFacade.LogError(exception.Message);
			}
		
		}

		public string GetName() {
			return "Show logs";
		}
	}
}
