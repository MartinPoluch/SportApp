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
using SportApp.gui;
using SportApp.sport.general;
using SportApp.sport.hockey;

namespace SportApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		private static readonly string LogFile = @"C:\Users\uzivatel\Desktop\data\logs.txt";

		private static MainWindow _instance;

		public MainWindow() {
			InitializeComponent();
			InitObservers();
			_instance = this;
			DataContext = this;
		}

		public static MainWindow GetInstance() {
			return _instance;
		}

		public void RefreshTeamTable() {
			SportContent.TeamsTableContent.Update();
		}

		public Team SelectedTeam() {
			return SportContent.TeamsTableContent.SelectedTeam();
		}

		public List<Team> SelectedTeams() {
			return SportContent.TeamsTableContent.SelectedTeams();
		}

		private void InitObservers() {
			//observers for sport selection
			SportSelector.Attach(SportContent);
			SportSelector.Attach(SportContent.SportInfoContent);
			SportSelector.Attach(SportContent.TeamsTableContent);
			SportSelector.Notify();

			//observers for logger
			LoggerFacade.RegisterConsoleLogObserver();
			LoggerFacade.RegisterFileLogObserver(LogFile);
			LoggerFacade.RegisterObserver(LastLogView);
			LoggerFacade.RegisterObserver(AllLogs.GetInstance());
		}

	}
}
