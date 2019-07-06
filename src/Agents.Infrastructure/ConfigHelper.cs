using System.Collections.Specialized;
using System.Configuration;

namespace Agents
{
    /// <summary>
    /// web.config操作类
    /// </summary>
    public sealed class ConfigHelper
    {
        private readonly static NameValueCollection _appSettings = ConfigurationManager.AppSettings;
        /// <summary>
        /// 得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>值</returns>
        public static string GetConfigString(string key)
        {
            return GetConfigString(_appSettings, key, string.Empty);
        }

        /// <summary>
        /// 得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>值</returns>
        public static string GetConfigString(string key, string defaultValue)
        {
            return GetConfigString(_appSettings, key, defaultValue);
        }

        public static string GetConfigString(NameValueCollection appSettings, string key, string defaultValue)
        {
            string str = appSettings == null ? defaultValue : appSettings[key];
            if (string.IsNullOrWhiteSpace(str)) str = defaultValue;
            return str;
        }

        public static string GetConfigString(NameValueCollection appSettings, string key)
        {
            return GetConfigString(appSettings, key, string.Empty);
        }

        /// <summary>
        /// 得到ConnectionStrings中的配置连接信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static ConnectionStringSettings GetConnection(string key)
        {
            return ConfigurationManager.ConnectionStrings[key];
        }

        /// <summary>
        /// 得到ConnectionStrings中的配置连接信息
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static ConnectionStringSettings GetConnection(string key, ConnectionStringSettings defaultValue)
        {
            return ConfigurationManager.ConnectionStrings[key] ?? defaultValue;
        }

        /// <summary>
        /// 得到ConnectionStrings中的配置连接字符串信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConnectionString(string key)
        {
            string result = string.Empty;
            if (GetConnection(key) != null) result = GetConnection(key).ConnectionString;
            return result;
        }

        /// <summary>
        /// 得到ConnectionStrings中的配置连接字符串信息
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string GetConnectionString(string key, string defaultValue)
        {
            string result = string.Empty;
            if (GetConnection(key) != null) result = GetConnection(key).ConnectionString;
            if (string.IsNullOrWhiteSpace(result)) result = defaultValue;
            return result;
        }
         
    }
}