using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer {
	public interface IObserver {
		void Update(IObservable observable);
	}
}
