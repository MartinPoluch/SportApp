using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;

namespace SportApp.sport.general {
	public abstract class Sport {

		public string Name { get; set; }
		public string Info { get; set; }

		//TODO, add access methods and make this field private, because methods can be overriden in child classes
		public List<Team> Teams { get; private set; }

		protected Sport(string name, string info) {
			Teams = new List<Team>();
			Name = name;
			Info = info;
		}

		public void AddNewTeam(Team team) {
			Teams.Add(team);
			LoggerFacade.LogInfo("New team added");
			LoggerFacade.LogInfo("Teams: " + Teams.ToString());
		}
	}
}
