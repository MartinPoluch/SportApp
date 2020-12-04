using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer.observerImpl {
	public class ConsoleLogObserver : IObserver {

		public void Update(IObservable observable) {
			Console.WriteLine(observable.GetState());
		}
	}
}
