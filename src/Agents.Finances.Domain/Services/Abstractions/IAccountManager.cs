
using System;
using System.Threading.Tasks;

namespace Agents.Finances.Domain.Services.Abstractions {
    /// <summary>
    /// 账户管理器
    /// </summary>
    public interface IAccountManager {

        /// <summary>
        /// 创建账户
        /// </summary>
        Task CreateAccount(Guid accountId);

        /// <summary>
        /// 删除账户
        /// </summary>
        Task DeleteAccount(string ids);
    }
}