using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.command.dataGenerator {

	public class DeleteAllTeamsCommand : CrudCommand {

		public override string GetName() {
			return "Delete all teams";
		}

		protected override void ExecuteAction() {
			SportFactory
				.GetInstance()
				.GetSport()
				.DeleteAllTeams();
		}

		protected override string SuccessMessage() {
			return "All teams was deleted";
		}

		protected override string ErrorMessage() {
			return "Cannot delete all teams";
		}
	}
}
