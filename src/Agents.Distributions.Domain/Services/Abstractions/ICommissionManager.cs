
using System;
using System.Threading.Tasks;
using Agents.Distributions.Domain.Models;
using Agents.Sales.Domain.Models;

namespace Agents.Distributions.Domain.Services.Abstractions {
    /// <summary>
    /// 佣金管理器
    /// </summary>
    public interface ICommissionManager {

        /// <summary>
        /// 添加佣金
        /// </summary>
        Task<Commission> CreateCommissionAsync(Commission model);
				
        /// <summary>
        /// 修改佣金
        /// </summary>
        Task UpdateCommission(Commission model);

        /// <summary>
        /// 删除佣金
        /// </summary>
        Task DeleteCommission(string ids);

        /// <summary>
        /// 计算佣金
        /// </summary>
        Task CalcCommissionAsync(Order order);
    }
}