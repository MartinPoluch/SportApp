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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyLogger;
using MyLogger.observer;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for LastLogView.xaml
	/// </summary>
	public partial class LastLogView : UserControl, IObserver {
		public LastLogView() {
			InitializeComponent();
		}

		public void Update(IObservable observable) {
			Log log = (Log) observable.GetState();
			LogView.Text = $"{log.Type}: {log.Message}";
		}
	}
}
