
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Services.Requests;

namespace Agents.Agents.Domain.Services.Abstractions {
    /// <summary>
    /// 用户管理器
    /// </summary>
    public interface IUserManager {
        /// <summary>
        /// 创建用户
        /// </summary>
        Task<Guid> CraeteUser(CreateUserRequest request);

        /// <summary>
        /// 删除用户
        /// </summary>
        Task DeleteUser(string ids);
    }
}