using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer {
	public interface IObservable {

		void Attach(IObserver observer);

		void Detach(IObserver observer);

		void Notify();

		void SetState(Object state);

		Object GetState();

	}
}
