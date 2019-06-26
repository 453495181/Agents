using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Util.Helpers;

namespace Agents.WebClients {

    /// <summary>
    /// WebClient操作帮助类
    /// </summary>
    public class WebClientHelper {

        /// <summary>
        /// Post
        /// </summary>
        public static async Task<T> PostAsync<T>(string url, object request) {
            var result = await Web.Client().Post(url).JsonData(request).ResultFromJsonAsync<T>();
            return result;
        }
    }
}
