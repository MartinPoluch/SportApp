using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger;
using SportApp.report;
using SportApp.sport.general;

namespace SportApp.command {
	public class GenerateReportCommand : ICommand {

		public void Execute() {
			try {
				ReportParameters reportParameters = new ReportParameters(); // parametre ziskane z GUI, co vsetko chcem zahrnut v reporte
				reportParameters.ShowDialog();
				if (reportParameters.IsSaved) {
					ReportDescription description = SportFactory.GetInstance().CreateReportDescription(); // vsetok obsah reportu
					reportParameters.FillReportDescription(description); // urcenie co vsetko z obsahu chcem zobrazit
					ReportBuilder reportBuilder = reportParameters.SelectedReportBuilder(); // ziskanie selectnuteho buildera z GUI
					ReportGenerator reportGenerator = new ReportGenerator(reportBuilder); // director
					reportGenerator.GenerateReport(description); 
					LoggerFacade.LogInfo($"{reportBuilder} report was successfully generated.");
				}
			} catch (Exception exception) {
				LoggerFacade.LogInfo($"Error during report generation: {exception}");
			}
			
		}

		public string GetName() {
			return "Generate Report";
		}
	}
}
