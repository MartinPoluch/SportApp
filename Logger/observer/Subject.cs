using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer {

	public abstract class Subject : IObservable {

		private List<IObserver> _observers;
		private State _state;

		protected Subject() {
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

		public void SetState(State state) {
			_state = state;
		}

		public State GetState() {
			return _state;
		}
	}
}
