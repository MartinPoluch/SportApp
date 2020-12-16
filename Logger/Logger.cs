using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogger.logTypes;
using MyLogger.observer;
using MyLogger.settings;
using Type = MyLogger.logTypes.Type;

namespace MyLogger
{
	public class Logger : Observable {

		public static RestrictionSetting RestrictionSetting { get; set; }
			= new RestrictionSetting() {
				MinPriority = Priority.None,
				MaxPriority = Priority.Maximum,
				VisibleTypes = new HashSet<Type>() { Type.Info, Type.Warning, Type.Error }
			};

		public static ContentSetting ContentSetting { get; set; }
			= new ContentSetting() {
				ShowDateAndTime = true,
				ShowCallerMethod = false,
				ShowCallerClass = false,
			};

		private static Logger _instance = null;
		private static StackTrace _stackTrace = new StackTrace();

		private Logger() {}

		public static Logger GetInstance() {
			return _instance ?? (_instance = new Logger());
		}

		private static void applyContentSetting(Log log, int numOfPrevMethods) {
			numOfPrevMethods++;
			if (ContentSetting.ShowDateAndTime) {
				log.DateTime = DateTime.Now;
			}

			if (ContentSetting.ShowCallerClass) {
				var reflectedType = _stackTrace.GetFrame(numOfPrevMethods).GetMethod().ReflectedType;
				if (!(reflectedType is null)) {
					log.CallerClass = reflectedType.Name;
				}
			}

			if (ContentSetting.ShowCallerMethod) {
				log.CallerMethod = _stackTrace.GetFrame(numOfPrevMethods).GetMethod().Name;
			}
		}

		public static void Log(Type type, Priority priority, string message, int numOfPrevMethods = 1) {
			Log log = LogFactory.GetInstance().GetLog(type, priority);
			log.Message = message;
			applyContentSetting(log, numOfPrevMethods);
			if (RestrictionSetting.ValidLog(log)) {
				_instance.SetState(log);
				_instance.Notify();
			}
		}
	}
}
