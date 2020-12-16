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
using MyLogger.observer;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for AllLogs.xaml
	/// </summary>
	public partial class AllLogs : Window, IObserver {

		private static List<Log> Logs = new List<Log>();
		private static AllLogs _instance = null;

		private AllLogs() {
			InitializeComponent();
		}

		public static AllLogs GetInstance() {
			return _instance ?? (_instance = new AllLogs());
		}

		public void Update(IObservable observable) {
			Log log = (Log)observable.GetState();
			Logs.Add(log);
			LogsTable.ItemsSource = Logs;
		}
	}
}
