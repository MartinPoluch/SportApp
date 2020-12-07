using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportApp.command.dataGenerator;
using SportApp.sport.general;

namespace SportApp.command {

	public class GenerateTeamsCommand : CrudCommand {

		public override string GetName() {
			return "Generate Teams";
		}

		protected override void ExecuteAction() {
			new DeleteAllTeamsCommand().Execute();
			Sport sport = SportFactory.GetInstance().GetSport();
			TeamGenerator generator = SportFactory.GetInstance().CreateTeamGenerator();
			foreach (string name in generator.TeamNames) {
				Team randomTeam = generator.RandomTeam(name);
				sport.AddNewTeam(randomTeam);
			}
		}

		protected override string SuccessMessage() {
			return $"{SportFactory.GetInstance().CreateTeamGenerator().TeamNames.Count} teams was generated";
		}

		protected override string ErrorMessage() {
			return "Cannot generate teams";
		}
	}
}
