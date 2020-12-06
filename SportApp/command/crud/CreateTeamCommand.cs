using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLogger;
using SportApp.gui;
using SportApp.sport.general;

namespace SportApp.command {
	public class CreateTeamCommand : CrudCommand {
		public override string GetName() {
			return "Create Team";
		}

		protected override void ExecuteAction() {
			ITeamForm form = SportFactory.GetInstance().CreateTeamForm();
			form.showForm();
			if (form.IsSaved()) {
				if (form.ValidInputs(false)) {
					Sport sport = SportFactory.GetInstance().GetSport();
					Team team = form.NewTeam();
					sport.AddNewTeam(team);
				}
				else {
					throw new CrudException("Invalid inputs !!!");
				}
			}
			else {
				throw new CrudException("Creation of new team operation was canceled.");
			}
		}

		protected override string SuccessMessage() {
			return "New team was created";
		}

		protected override string ErrorMessage() {
			return "Error during creation of new team";
		}
	}
}
