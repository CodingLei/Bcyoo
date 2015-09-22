using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XianShou.bcyoo.Common.Helper
{
	public class Factory
	{
		private static readonly Dictionary<string, object> Container = new Dictionary<string, object>();

		/// <summary>
		/// 并发锁
		/// </summary>
		private static readonly object SyncLock = new object();

		public static T CreateBookingPushInstance<T>(string className) where T : class
		{
			if (!Container.ContainsKey(className) || Container[className] == null)
			{
				lock (SyncLock)
				{
					if (!Container.ContainsKey(className) || Container[className] == null)
					{
						if (string.IsNullOrWhiteSpace(className)) return null;
						Type classType = Type.GetType(className);
						if (classType == null) return null;
						Container[className] = Activator.CreateInstance(classType);
					}
				}
			}
			return Container[className] as T;
		}
	}
}
