using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger.observer.observerImpl {
	public class FileLogObserver : IObserver {

		private string FilePath { get; set; }

		public FileLogObserver(string filePath) {
			FilePath = filePath;
		}

		public void Update(IObservable observable) {
			File.AppendAllText(FilePath, observable.GetState() + Environment.NewLine);
		}
	}
}
