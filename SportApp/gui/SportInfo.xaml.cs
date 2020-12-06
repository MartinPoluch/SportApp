using System;
using System.Collections.Generic;
using System.Globalization;
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
using MyLogger.observer;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for SportInfo.xaml
	/// </summary>
	public partial class SportInfo : UserControl, IObserver {
		public SportInfo() {
			InitializeComponent();
			DataContext = this;
		}

		public void Update(IObservable observable) {
			InfoText.Text = SportFactory.GetInstance().GetSport().Info;
		}
	}
}
