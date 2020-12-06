﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.sport.general;

namespace SportApp.command {
	public class DeleteTeamCommand : CrudCommand {

		public override string GetName() {
			return "Delete Team";
		}

		protected override void ExecuteAction() {
			Team team = MainWindow.GetInstance().SelectedTeam();
			Sport sport = SportFactory.GetInstance().GetSport();
			sport.DeleteTeam(team);
		}

		protected override string SuccessMessage() {
			return "Team was successfully deleted.";
		}

		protected override string ErrorMessage() {
			return "Cannot delete team.";
		}
	}
}
