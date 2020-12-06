using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer {

	public abstract class Observable : IObservable {

		private List<IObserver> _observers;
		private Object _state;

		protected Observable() {
			_observers = new List<IObserver>();
			_state = null;
		}

		public void Attach(IObserver observer) {
			_observers.Add(observer);
		}

		public void Detach(IObserver observer) {
			_observers.Remove(observer);
		}

		public void Notify() {
			foreach (IObserver observer in _observers) {
				observer.Update(this);
			}
		}

		public void SetState(Object state) {
			_state = state;
		}

		public Object GetState() {
			return _state;
		}
	}
}
