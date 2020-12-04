
using System;
using System.Collections.Generic;
using SportApp.sport.general;
using SportApp.sport.hockey;

public abstract class SportFactory {

	private static Dictionary<SportType, SportFactory> _instances;
	private static ISportSelector _sportSelector;

	protected SportFactory(){

	}

	public void RegisterSportSelector(ISportSelector sportSelector) {
		_sportSelector = sportSelector;
	}

	/// 
	/// <param name="sportType"></param>
	public SportFactory GetInstance(SportType sportType) {
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
				default: {
					throw new ArgumentException($"Illegal argument: {sportType}");
				}
			}
			_instances[sportType] = factory;
		}
		return factory;
	}

	public SportFactory GetInstance() {
		if (_sportSelector != null) {
			return GetInstance(_sportSelector.SelectedSport());
		}
		else {
			throw new Exception("No sport selector registered");
		}
	}

	public Team CreateTeam(){
		return null;
	}

	public ReportDescription CreateReportDescription(){

		return null;
	}

}