using System.Configuration;

namespace XianShou.bcyoo.Common.Helper
{
    /// <summary>
    /// AppSettingsHelper
    /// </summary>
    public static class AppSettingsHelper
    {
        private const string ConfigGourpName = "AppSettings";

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key] ?? string.Empty;
        }

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string GetString(string key, string defaultValue = "")
        {
            string setting = GetValue(key);
            return !string.IsNullOrEmpty(setting) ? setting : defaultValue;
        }

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static bool GetBool(string key, bool defaultValue = false)
        {
            string setting = GetValue(key);
            if (!string.IsNullOrEmpty(setting))
            {
                switch (setting.ToLower())
                {
                    case "false":
                    case "0":
                    case "n":
                        return false;
                    case "true":
                    case "1":
                    case "y":
                        return true;
                }
            }
            return defaultValue;
        }

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int GetInt(string key, int defaultValue = 0)
        {
            string setting = GetValue(key);
            if (!string.IsNullOrEmpty(setting))
            {
                int i;
                if (int.TryParse(setting, out i))
                {
                    return i;
                }
            }
            return defaultValue;
        }

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double GetDouble(string key, double defaultValue = 0)
        {
            string setting = GetValue(key);
            if (!string.IsNullOrEmpty(setting))
            {
                double d;
                if (double.TryParse(setting, out d))
                {
                    return d;
                }
            }
            return defaultValue;
        }

        /// <summary>
        /// 根据Key获取Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static byte GetByte(string key, byte defaultValue = 0)
        {
            string setting = GetValue(key);
            if (!string.IsNullOrEmpty(setting))
            {
                byte b;
                if (byte.TryParse(setting, out b))
                {
                    return b;
                }
            }
            return defaultValue;
        }
    }
}