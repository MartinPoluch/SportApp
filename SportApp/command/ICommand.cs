﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp.command {
	public interface ICommand {
		void Execute();
		string GetName();
	}
}
