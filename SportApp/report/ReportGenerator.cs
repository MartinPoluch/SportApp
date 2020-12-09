using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class ReportGenerator {

	private static readonly string DefaultSaveDirectory = @"C:\Users\uzivatel\Desktop\reports";

	public ReportBuilder ReportBuilder { get; set; }

	public ReportGenerator(ReportBuilder reportBuilder) {
		ReportBuilder = reportBuilder;
	}

	public void GenerateReport(ReportDescription description) {
		if (description.IncludeHeader) {
			ReportBuilder.AddHeader(description.Header());
		}

		if (description.IncludeInfo) {
			ReportBuilder.AddInfo(description.Info());
		}

		if (description.IncludeTeams) {
			ReportBuilder.AddTeams(description.ColumnNames, description.Teams());
		}

		Report report = ReportBuilder.GetReport();
		report.Directory = DefaultSaveDirectory;
		report.Name = $"{ReportBuilder}_report_{description.Header()}";
		report.Save();
		report.Open();
	}

}