using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;
using MyLogger.observer;
using Type = MyLogger.logTypes.Type;

namespace MyLogger {
	public class Log : State{

		private LogSharedState LogSharedState { get; }

		public Priority Priority {
			get { return LogSharedState.Priority; }
		}

		public Type Type {
			get { return LogSharedState.Type; }
		}

		public string Message { get; set; }

		public DateTime DateTime { get; set; }

		public string CallerClass { get; set; }

		public string CallerMethod { get; set; }

		public Log(LogSharedState logSharedState) {
			LogSharedState = logSharedState;
			Message = "";
			CallerClass = "";
			CallerMethod = "";
		}

		public override string ToString() {
			string format = "dd.MM.yyyy H:mm:ss";
			string formattedDateTime = DateTime.ToString(format);
			string separator = ((CallerMethod != "") && (CallerClass != "")) ? "." : " ";
			return $"{formattedDateTime} " +
			       $"{CallerClass}" +
			       $"{separator}" +
			       $"{CallerMethod} " +
			       $"[{Type}] " +
			       $"[{Priority}] " +
			       $"{Message}";
		}
	}
}
