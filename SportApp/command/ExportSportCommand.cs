﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public class ExportSportCommand : ICommand {
		public void Execute() {
			throw new NotImplementedException("Export is not implemented.");
		}

		public string GetName() {
			return "Export SPort";
		}
	}
}