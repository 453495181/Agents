
using System;
using System.Threading.Tasks;
using Agents.Distributions.Domain.Models;

namespace Agents.Distributions.Domain.Services.Abstractions {
    /// <summary>
    /// 域名分类管理器
    /// </summary>
    public interface IDomainTypeManager {

        /// <summary>
        /// 添加域名分类
        /// </summary>
        Task<DomainType> CreateDomainTypeAsync(DomainType model);
				
        /// <summary>
        /// 修改域名分类
        /// </summary>
        Task UpdateDomainType(DomainType model);

        /// <summary>
        /// 删除域名分类
        /// </summary>
        Task DeleteDomainType(string ids);
    }
}