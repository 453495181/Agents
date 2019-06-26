using Util.Exceptions;
using Util.Webs.Commons;

namespace Agents.ResultExtensions {
    /// <summary>
    /// Result扩展
    /// </summary>
    public static class ResultExtension {
        /// <summary>
        /// Result错误验证
        /// </summary>
        /// <param name="result">result对象</param>
        /// <param name="errorMsg">错误消息</param>
        public static void ErrorValidate(this Result result, string errorMsg = "") {
            if (result.Code == StateCode.Fail) {
                throw new Warning(string.IsNullOrWhiteSpace(errorMsg) ? result.Message : errorMsg);
            }
        }
    }
}