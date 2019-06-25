using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Finances.Domain.Services.Abstractions;
using Util.Domains.Services;

namespace Agents.Agents.Domain.Services.Implements {
    /// <summary>
    /// 用户管理器
    /// </summary>
    public class UserManager : DomainServiceBase, IUserManager {
        /// <summary>
        /// 初始化用户管理器
        /// </summary>
        public UserManager() {
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        public async Task<Guid> CraeteUser(string userName, string passWord) {
            return Guid.NewGuid();
        }
    }
}
