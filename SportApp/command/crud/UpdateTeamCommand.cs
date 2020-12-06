using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {

	public class UpdateTeamCommand : CrudCommand {
		public override string GetName() {
			return "Update Team";
		}

		protected override void ExecuteAction() {
			throw new NotImplementedException();
		}

		protected override string SuccessMessage() {
			throw new NotImplementedException();
		}

		protected override string ErrorMessage() {
			throw new NotImplementedException();
		}
	}
}
