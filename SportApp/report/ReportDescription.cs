
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SportApp.sport.general;


public class ReportDescription {

	public bool IncludeHeader { get; set; }
	public bool IncludeInfo{ get; set; }
	public bool IncludeTeams{ get; set; }

	private Sport Sport { get; }
	public string[] ColumnNames { get; }

	public ReportDescription(Sport sport, string[] columnNames) {
		Sport = sport;
		ColumnNames = columnNames;
	}

	public string Header() {
		return Sport.Name;
	}

	public string Info() {
		return Sport.Info;
	}

	public List<Team> Teams() {
		return Sport.GetTeams();
	}
}