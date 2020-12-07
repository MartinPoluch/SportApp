
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MyLogger.observer;
using SportApp.gui;
using SportApp.sport.football;
using SportApp.sport.general;
using SportApp.sport.hockey;

public abstract class SportFactory {

	private static Dictionary<SportType, SportFactory> _instances = new Dictionary<SportType, SportFactory>();
	private static SportType selectedSportType;

	protected SportFactory() {
	}

	public static void UpdateSportType(SportType sportType) {
		selectedSportType = sportType;
	}

	/// 
	/// <param name="sportType"></param>
	public static SportFactory GetInstance(SportType sportType) {
		SportFactory factory = null;
		if (_instances.ContainsKey(sportType)) {
			factory = _instances[sportType];
		}
		else {
			switch (sportType) {

				case SportType.Hockey: {
					factory = new HockeyFactory();
					break;
				}
				case SportType.Football: {
					factory = new FootballFactory();
					break;
				}
				default: {
					throw new ArgumentException($"Illegal argument: {sportType}");
				}
			}
			_instances[sportType] = factory;
		}
		return factory;
	}

	public static SportFactory GetInstance() {
		return GetInstance(selectedSportType);
	}

	public abstract Sport GetSport();

	public abstract ITeamForm CreateTeamForm();

	public abstract TeamGenerator CreateTeamGenerator();

	public abstract ReportDescription CreateReportDescription();

}