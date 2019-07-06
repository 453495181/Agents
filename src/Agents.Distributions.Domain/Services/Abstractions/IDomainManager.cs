
using System;
using System.Threading.Tasks;
using Agents.Distributions.Domain.Models;

namespace Agents.Distributions.Domain.Services.Abstractions {
    /// <summary>
    /// 域名管理器
    /// </summary>
    public interface IDomainManager {

        /// <summary>
        /// 添加域名
        /// </summary>
        Task<Models.Domain> CreateDomainAsync(Models.Domain model);
				
        /// <summary>
        /// 修改域名
        /// </summary>
        Task UpdateDomain(Models.Domain model);

        /// <summary>
        /// 删除域名
        /// </summary>
        Task DeleteDomain(string ids);
    }
}