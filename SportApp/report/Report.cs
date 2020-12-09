

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using MyLogger;

public class Report {

	private StringBuilder Content { get; }

	public string Directory { get; set; }
	public string Name { get; set; }

	public string FileExtension { get; set; }

	public string FullFileName {
		get {
			return $@"{Directory}\{Name}.{FileExtension}";
		}
	}

	public Report(){
		Content = new StringBuilder();
	}

	/**
	 * Deep copy
	 */
	public Report(Report report) {
		Content = new StringBuilder(report.Content.ToString());
		Directory = report.Directory;
		Name = report.Name;
		FileExtension = report.FileExtension;
	}

	public void AddText(string text) {
		Content.Append(text);
	}

	public void AddNewLine(string text) {
		AddText(text);
		AddText("\n");
	}

	public void Save() {
		using (StreamWriter sw = File.CreateText(FullFileName)) {
			sw.WriteLine(Content.ToString());
		}
	}

	public void Open() {
		if (File.Exists(FullFileName)) {
			Process.Start(FullFileName);
		}
	}

}