using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
using SportApp.sport.hockey;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for TableContent.xaml
	/// </summary>
	public partial class TableContent : UserControl, IObserver {

		public TableContent() {
			InitializeComponent();
			DataContext = this;
		}

		public void Update(IObservable observable) {
			Update();
		}

		private IList CreateSpecificTeams(List<Team> abstractTeams) {
			Type teamType = abstractTeams[0].GetType(); // konkretny typ sportu
			Type objectType = typeof(List<>);
			var genericType = objectType.MakeGenericType(teamType); // list s generikom konretneho sportu
			IList specificTeams = (IList)Activator.CreateInstance(genericType); // instancia listu s generikom konkretneho sportu
			foreach (var team in abstractTeams) {
				specificTeams.Add(team);
			}

			return specificTeams;
		}

		public void Update(){
			TeamsTable.SelectedItem = null;
			List<Team> abstractTeams = SportFactory.GetInstance().GetSport().GetTeams();
			if (abstractTeams.Count > 0) {
				TeamsTable.ItemsSource = CreateSpecificTeams(abstractTeams);
				//(TeamsTable.ItemsSource as DataView).Sort = "Points";
			}
			else {
				TeamsTable.ItemsSource = null;
			}
			TeamsTable.Items.Refresh();
		}

		public Team SelectedTeam() {
			return (Team) TeamsTable.SelectedItem;
		}
	}
}
