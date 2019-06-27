using System;
using System.Threading.Tasks;
using Util;
using Util.Helpers;

namespace Agents.UserMocks {

    /// <summary>
    /// 用户模拟
    /// </summary>
    public class UserMock {

        /// <summary>
        /// 获取当前登陆用户
        /// </summary>
        public static Guid CurrentUserId() {
            return "9655735F-912F-473C-9EC4-183062EF17BD".ToGuid();
        }
    }
}
