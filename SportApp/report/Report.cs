

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


public class Report {

	private StringBuilder Content { get; set; }

	public Report(){

	}

	public void AddText(string text) {
		Content.Append(text);
	}

	public string PlainText() {
		return Content.ToString();
	}

	public void Save() {

	}

	public void Open() {
		//Process.Start(fileName);
	}


}