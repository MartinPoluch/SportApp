
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class HtmlReportBuilder : ReportBuilder {

	private Report _report;

	public HtmlReportBuilder(){
		_report = new Report() {
			FileExtension = ".html"
		};
		_report.AddNewLine("<!DOCTYPE html>");
		_report.AddNewLine("<html>");
		_report.AddNewLine("<head>");
		AddCssStyles();
		_report.AddNewLine("</head>");
		_report.AddNewLine("<body>");
	}

	private void AddCssStyles() {
		_report.AddNewLine("<style>");

		_report.AddNewLine("table {" +
		                   "width: 100%; " +
		                   "border-collapse: collapse; " +
		                   "font-family: Arial, Helvetica, sans-serif; " +
		                   "text-align: center;" +
		                   "}");

		_report.AddNewLine("table th { " +
		                   "background-color: black;" +
		                   "color: white;" +
		                   "}");

		_report.AddNewLine("tr td, th {" +
		                   "text - align: center;" +
		                   "}");

		_report.AddNewLine("td, th {" +
						   "border: 1px solid #dddddd;" +
						   "padding:8px;" +
						   "}");

		_report.AddNewLine("tr:nth-child(even) {" +
		                   "background-color: #dddddd;" +
		                   "}");
		_report.AddNewLine("</style>");
	}

	public void AddHeader(String text){
		_report.AddNewLine($"<h2>{text}</h2>");
	}

	public void AddInfo(String text) {
		_report.AddNewLine($"<p>{text}</p>");
	}

	public void AddTeams(string[] headers, List<Team> teams) {
		_report.AddNewLine("</br>");
		_report.AddNewLine("<table>");
		_report.AddNewLine("<tr>");
		foreach (string header in headers) {
			_report.AddNewLine($"<th>{header}</th>");
		}
		_report.AddNewLine("</tr>");

		
		foreach (Team team in teams) {
			_report.AddNewLine("<tr>");
			foreach (string value in team.PropertyValues()) {
				_report.AddNewLine($"<td>{value}</td>");
			}
			_report.AddNewLine("</tr>");
		}
		_report.AddNewLine("</table>");
	}


	/**
	 * Pred vratenim reportu je jeho obsah modifikovany pridanim koncovych html znaciek,
	 * z tohto dovodu vytvaram kopiu (deep) povodneho reportu ktoru modifikujem,
	 * aby sa dala zavolat metoda GetReport() aj viacej krat.
	 */
	public Report GetReport(){
		Report finishedReport = new Report(_report);
		finishedReport.AddNewLine("</body>");
		finishedReport.AddNewLine("</html>");
		return finishedReport;
	}

	public override string ToString() {
		return "HTML";
	}
}