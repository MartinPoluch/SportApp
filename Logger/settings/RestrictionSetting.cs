using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;

namespace MyLogger.settings {
	public class RestrictionSetting {

		public HashSet<Type> VisibleTypes { get; set; }

		public Priority MinPriority { get; set; }

		public Priority MaxPriority { get; set; }

		public void ShowOnlyLowerOrEqualPriority(Priority priority) {
			MinPriority = Priority.None;
			MaxPriority = priority;
		}

		public void ShowOnlyHigherOrEqualPriority(Priority priority) {
			MinPriority = priority;
			MaxPriority = Priority.Maximum;
		}

		public void ShowOnlyPriority(Priority priority) {
			MinPriority = priority;
			MaxPriority = priority;
		}

		public bool ValidLog(Log log) {
			return ((MinPriority <= log.Priority) || (log.Priority <= MaxPriority)) && 
			       (VisibleTypes.Contains(log.Type));
		}
		
	}
}
