using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MyLogger;

namespace SportApp.report {
	/// <summary>
	/// Interaction logic for ReportParameters.xaml
	/// </summary>
	public partial class ReportParameters : Window {

		public bool IsSaved { get; private set; }

		public ReportParameters() {
			InitializeComponent();
			ReportBuilder[] builders = {
				new HtmlReportBuilder(), 
				new CsvReportBuilder(),
			};
			ReportFormats.ItemsSource = builders;
			IsSaved = false;
		}

		public void Generate(object sender, RoutedEventArgs e) {
			IsSaved = true;
			Close();
		}

		private bool IncludeHeader() {
			return (HeaderCb.IsChecked != null) && (bool) HeaderCb.IsChecked;
		}

		private bool IncludeInfo() {
			return (InfoCb.IsChecked != null) && (bool)InfoCb.IsChecked;
		}

		private bool IncludeTeams() {
			return (TeamsCb.IsChecked != null) && (bool)TeamsCb.IsChecked;
		}

		public void FillReportDescription(ReportDescription description) {
			description.IncludeHeader = IncludeHeader();
			description.IncludeInfo = IncludeInfo();
			description.IncludeTeams = IncludeTeams();
		}

		public ReportBuilder SelectedReportBuilder() {
			return (ReportBuilder)ReportFormats.SelectedItem;
		}
	}
}
