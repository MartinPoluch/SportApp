using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;
using Type = MyLogger.logTypes.Type;

namespace MyLogger {

	/**
	 * Singleton, class for creating logs.
	 */
	public class LogFactory {

		private static LogFactory _instance = null;

		private Dictionary<Tuple<Type, Priority>, LogSharedState> LogSharedStates { get; set; }

		private LogFactory() {
			LogSharedStates = new Dictionary<Tuple<Type, Priority>, LogSharedState>();
		}

		public static LogFactory GetInstance() {
			return _instance ?? (_instance = new LogFactory());
		}

		public Log GetLog(Type type, Priority priority) {
			var key = new Tuple<Type, Priority>(type, priority);
			LogSharedState sharedState = null;
			if (LogSharedStates.ContainsKey(key)) {
				sharedState = LogSharedStates[key];
			}
			else {
				sharedState = new LogSharedState(type, priority);
				LogSharedStates[key] = sharedState;
			}
			
			return new Log(sharedState);
		}
	}
}
