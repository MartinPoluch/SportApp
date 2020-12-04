using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;

namespace MyLogger {

	/**
	 * State which is shared between all flyweights (logs)
	 */
	public class LogSharedState {

		public Type Type { get; }

		public Priority Priority { get; }

		public LogSharedState(Type type, Priority priority) {
			Type = type;
			Priority = priority;
		}
	}
}
