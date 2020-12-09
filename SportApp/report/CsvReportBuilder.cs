using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.report {
	public class CsvReportBuilder : ReportBuilder {

		private static readonly string Delimiter = ";";

		private Report _report;

		public CsvReportBuilder() {
			_report = new Report() {
				FileExtension = "csv"
			};
		}

		public void AddHeader(string text) {
			_report.AddNewLine($"{text}{Delimiter}");
		}

		public void AddInfo(string text) {
			_report.AddNewLine($"{text}{Delimiter}");
		}

		public void AddTeams(string[] headers, List<Team> teams) {
			foreach (string header in headers) {
				_report.AddText($"{header}{Delimiter}");
			}
			_report.AddNewLine("");

			foreach (Team team in teams) {
				foreach (string property in team.PropertyValues()) {
					_report.AddText($"{property}{Delimiter}");
				}
				_report.AddNewLine("");
			}
		}

		public Report GetReport() {
			return _report;
		}

		public override string ToString() {
			return "CSV";
		}
	}
}
