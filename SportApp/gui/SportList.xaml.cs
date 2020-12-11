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
using MyLogger.observer;
using SportApp.sport.general;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for UserControl1.xaml
	/// </summary>
	public partial class SportList : UserControl, IObservable {

		public static readonly SportType DefaultSportType = SportType.Hockey;
		private List<IObserver> _observers;

		public SportType SelectedSportType { get; set; }

		public SportList() {
			InitializeComponent();
			_observers = new List<IObserver>();
			SelectedSportType = DefaultSportType;
			Sports.ItemsSource = Enum.GetValues(typeof(SportType));
			DataContext = this;
		}

		private void SelectSport(object sender, MouseButtonEventArgs e) {
			if (Sports.SelectedItem != null) {
				SelectedSportType = (SportType)Sports.SelectedItem;
				Notify();
			}
		}

		public void Attach(IObserver observer) {
			_observers.Add(observer);
		}

		public void Detach(IObserver observer) {
			_observers.Remove(observer);
		}

		public void Notify() {
			SportFactory.UpdateSportType(SelectedSportType);
			foreach (IObserver observer in _observers) {
				observer.Update(this);
			}
		}

		public void SetState(Object state) {
			// not implemented
		}

		public Object GetState() {
			return SelectedSportType;
		}
	}
}
