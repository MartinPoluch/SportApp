﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyLogger;
using MyLogger.logTypes;
using MyLogger.observer;

namespace SportApp.command {
	public abstract class CrudCommand : ICommand {

		public abstract string GetName();

		protected abstract void ExecuteAction();
		 
		protected abstract string SuccessMessage();

		protected abstract string ErrorMessage();



		public void Execute() {
			try {
				ExecuteAction();
				MainWindow.GetInstance().RefreshTeamTable();
				LoggerFacade.LogInfo(SuccessMessage());
			}
			catch (CrudException crudException) {
				LoggerFacade.LogError($"{ErrorMessage()} {crudException.Message}", Priority.Low);
				//MessageBox.Show(exception.Message, "Wrong input", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			catch (Exception exception) {
				LoggerFacade.LogError($"Unexpected error {exception.Message}");
				//MessageBox.Show(exception.Message, "Wrong input", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
