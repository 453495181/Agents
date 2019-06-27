using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Agents.ResultExtensions;
using Util.Helpers;
using Util.Webs.Commons;

namespace Agents.WebClients {

    /// <summary>
    /// Util Result WebClient操作帮助类
    /// </summary>
    public class WebClientResultHelper {

        /// <summary>
        /// Post
        /// </summary>
        public static async Task<dynamic> PostAsync(string url, object request) {
            var result = await Web.Client().Post(url).JsonData(request).ResultFromJsonAsync<Result>();
            result.ErrorValidate();
            return result.Data;
        }
    }
}
