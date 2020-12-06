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
using SportApp.sport.general;

namespace SportApp.gui {
	
	public partial class SportContent : UserControl, IObserver {

		public Sport Sport { get; set; }

		public SportContent() {
			InitializeComponent();
			DataContext = this;
		}

		public void Update(IObservable observable) {
			Header.Content = SportFactory.GetInstance().GetSport().Name;
		}
	}
}
