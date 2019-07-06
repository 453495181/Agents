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
            //return "DDFB385B-ACBC-4212-9F47-0098F3B764B5".ToGuid();//YXL
            return "8FEC825E-6324-43A7-BE6E-247BB93432EB".ToGuid();//HC
            //return Guid.NewGuid();
        }
    }
}
