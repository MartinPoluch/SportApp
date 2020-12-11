using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;
using SportApp.sport.general;

namespace SportApp.command {

	public class UpdateTeamCommand : CrudCommand {
		public override string GetName() {
			return "Update Team";
		}

		protected override void ExecuteAction() {
			Team team = MainWindow.GetInstance().SelectedTeam();
			if (team == null) {
				throw new CrudException("No team selected.");
			}

			ITeamForm form = SportFactory.GetInstance().CreateTeamForm();
			form.fillForm(team);
			form.showForm();
			if (form.IsSaved()) {
				if (form.ValidInputs(true)) {
					Sport sport = SportFactory.GetInstance().GetSport();
					Team updatedTeam = form.NewTeam();
					sport.UpdateTeam(updatedTeam);
				}
				else {
					throw new CrudException("Invalid inputs !!!");
				}
			}
			else {
				throw new CrudException("Update of team was canceled.");
			}
		}

		protected override string SuccessMessage() {
			return "Team was successfully updated";
		}

		protected override string ErrorMessage() {
			return "Error during team update";
		}
	}
}
