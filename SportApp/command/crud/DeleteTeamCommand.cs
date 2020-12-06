using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class DeleteTeamCommand : CrudCommand {

		public override string GetName() {
			return "Delete Team";
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
