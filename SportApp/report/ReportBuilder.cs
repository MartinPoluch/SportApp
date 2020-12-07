
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public interface ReportBuilder  {

	void AddHeader(String text);

	void AddInfo(String text);

	void AddTeams(string[] headers, List<Team> teams);

	Report GetReport();
}