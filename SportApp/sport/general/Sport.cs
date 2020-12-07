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

		public Dictionary<string, Team> Teams { get; set; }

		protected Sport(string name, string info) {
			//Teams = new List<Team>();
			Teams = new Dictionary<string, Team>();
			Name = name;
			Info = info;
		}

		public bool AddNewTeam(Team team) {
			if (Teams.ContainsKey(team.Name)) {
				return false; // name is not unique
			}
			else {
				Teams[team.Name] = team;
				return true;
			}
		}

		public bool UpdateTeam(Team team) {
			if (Teams.ContainsKey(team.Name)) {
				Teams[team.Name] = team;
				return true;
			}
			else {
				return false;
			}
		}

		public bool DeleteTeam(Team team) {
			return Teams.Remove(team.Name);
		}

		public Team GetTeam(string name) {
			return (Teams.ContainsKey(name)) ? Teams[name] : null;
		}

		public List<Team> GetTeams() {
			return Teams.Values.ToList();
		}

		public void DeleteAllTeams() {
			Teams.Clear();
		}
	}
}
