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

		public virtual bool AddNewTeam(Team team) {
			if (Teams.ContainsKey(team.Name)) {
				return false; // name is not unique
			}
			else {
				Teams[team.Name] = team;
				return true;
			}
		}

		public virtual bool UpdateTeam(Team team) {
			if (Teams.ContainsKey(team.Name)) {
				Teams[team.Name] = team;
				return true;
			}
			else {
				return false;
			}
		}

		public virtual bool DeleteTeam(Team team) {
			return Teams.Remove(team.Name);
		}

		public virtual Team GetTeam(string name) {
			return (Teams.ContainsKey(name)) ? Teams[name] : null;
		}

		public virtual List<Team> GetTeams() {
			return Teams.Values
				.OrderBy(x => x.Points)
				.ToList();
		}

		public virtual void DeleteAllTeams() {
			Teams.Clear();
		}
	}
}
