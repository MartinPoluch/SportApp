using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;
using MyLogger.observer;
using MyLogger.observer.observerImpl;
using MyLogger.settings;
using Type = MyLogger.logTypes.Type;

namespace MyLogger {
	public static class LoggerFacade {

		private static readonly int NUM_OF_PREV_METHODS = 3;

		public static readonly ContentSetting SimpleContent = new ContentSetting() {
			ShowDateAndTime = false,
			ShowCallerClass = false,
			ShowCallerMethod = false,
		};

		public static readonly ContentSetting BasicContent = new ContentSetting() {
			ShowDateAndTime = true,
			ShowCallerClass = false,
			ShowCallerMethod = false,
		};

		public static readonly ContentSetting AdvancedContent = new ContentSetting() {
			ShowDateAndTime = true,
			ShowCallerClass = true,
			ShowCallerMethod = true,
		};

		public static readonly RestrictionSetting NoRestriction = new RestrictionSetting() {
			MinPriority = Priority.None,
			MaxPriority = Priority.Maximum,
			VisibleTypes = new HashSet<Type>() { Type.Info, Type.Warning, Type.Error }
		};

		public static void SetCustomContentSetting(ContentSetting contentSetting) {
			Logger.ContentSetting = contentSetting;
		}

		public static void SetSimpleContent() {
			SetCustomContentSetting(SimpleContent);
		}

		public static void SetBasicContent() {
			SetCustomContentSetting(BasicContent);
		}

		public static void SetAdvancedContent() {
			SetCustomContentSetting(AdvancedContent);
		}

		public static void SetCustomRestrictions(RestrictionSetting restrictionSetting) {
			Logger.RestrictionSetting = restrictionSetting;
		}

		public static void SetNoRestrictions() {
			SetCustomRestrictions(NoRestriction);
		}

		public static Logger GetSimpleLoggerInstance() {
			return Logger.GetInstance();
		}

		public static void RegisterObserver(IObserver observer) {
			GetSimpleLoggerInstance().Attach(observer);
		}

		public static ConsoleLogObserver RegisterConsoleLogObserver() {
			ConsoleLogObserver consoleLog = new ConsoleLogObserver();
			GetSimpleLoggerInstance().Attach(consoleLog);
			return consoleLog;
		}

		public static FileLogObserver RegisterFileLogObserver(string filePath) {
			FileLogObserver fileLog = new FileLogObserver(filePath);
			GetSimpleLoggerInstance().Attach(fileLog);
			return fileLog;
		}

		public static void UnRegisterObserver(IObserver observer) {
			GetSimpleLoggerInstance().Detach(observer);
		}

		public static void LogInfo(string message, Priority priority = Priority.Low) {
			Logger.Log(Type.Info, priority, message, NUM_OF_PREV_METHODS);
		}

		public static void LogWarning(string message, Priority priority = Priority.Medium) {
			Logger.Log(Type.Warning, priority, message, NUM_OF_PREV_METHODS);
		}

		public static void LogError(string message, Priority priority = Priority.High) {
			Logger.Log(Type.Error, priority, message, NUM_OF_PREV_METHODS);
		}
	}
}
