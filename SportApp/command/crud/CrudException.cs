using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class CrudException : Exception {
		public CrudException(string message) : base(message) {
		}
	}
}
