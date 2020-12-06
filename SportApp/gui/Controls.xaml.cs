﻿using System;
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
using SportApp.command;

namespace SportApp.gui {
	/// <summary>
	/// Interaction logic for Controls.xaml
	/// </summary>
	public partial class Controls : UserControl {

		public Controls() {
			InitializeComponent();
			CreateTeam.Command = new CreateTeamCommand();
			UpdateTeam.Command = new UpdateTeamCommand();
			DeleteTeam.Command = new DeleteTeamCommand();
			Generate.Command = new GenerateReportCommand();
			DataContext = this;
		}
	}
}