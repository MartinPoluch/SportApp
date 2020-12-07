
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class HockeyTeam : Team {

	public int WinsInOvertime { get; set; }
	public int LosesInOvertime { get; set; }

	public HockeyTeam(){
	}

	public HockeyTeam(Team team) : base(team) {
	}

	public override List<string> PropertyValues() {
		List<string> properties = base.PropertyValues();
		properties.Add(WinsInOvertime.ToString());
		properties.Add(LosesInOvertime.ToString());
		return properties;
	}
}