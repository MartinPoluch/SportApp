using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.logTypes {
	public enum Priority {
		None = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Maximum = Int32.MaxValue, 
	}
}
