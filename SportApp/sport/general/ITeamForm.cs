using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.sport.general {

	public interface ITeamForm {

		void showForm();
		bool ValidInputs(bool update);
		bool IsSaved();
		Team NewTeam();
		void fillForm(Team team);

	}
}
