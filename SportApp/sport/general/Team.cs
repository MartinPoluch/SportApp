

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SportApp.sport.general;


public class Team {

	public string Name { get; set; }
	public int Matches { get; set; }
	public int Wins { get; set; }
	public int Loses { get; set; }
	public int Points { get; set; }
	public Score Score { get; set; }

	public Team() {
	}

	public Team(Team team) {
		Name = team.Name;
		Matches = team.Matches;
		Wins = team.Wins;
		Loses = team.Loses;
		Points = team.Points;
		Score = team.Score;
	}

	public virtual List<string> PropertyValues() {
		return new List<string>() { 
			Name, 
			Matches.ToString(), 
			Wins.ToString(), 
			Loses.ToString(), 
			Points.ToString(), 
			Score.ToString() 
		};
	}

	

}