using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XianShou.bcyoo.Common.Helper
{
    public static class DictionaryHelper
    {
        /// <summary>
        /// 获取键值对应的值，并转换成指定形参类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetValue<T>(this Dictionary<string, object> dictionary, string key)
        {
            if (!dictionary.ContainsKey(key)) return default(T);
            return (T) dictionary[key];
        }

        /// <summary>
        /// 判断键值是否包含指定形参类型的值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool ContainsType<T>(this Dictionary<string, object> dictionary, string key)
        {
            return dictionary.ContainsKey(key) && dictionary[key] is T;
        }
    }
}
