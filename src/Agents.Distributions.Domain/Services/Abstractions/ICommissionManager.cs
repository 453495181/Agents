
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
        /// 计算佣金
        /// </summary>
        Task CalcCommissionAsync(Order order);

        /// <summary>
        /// 支付订单佣金
        /// </summary>
        Task PayedOrderCommissionAsync(Order order);
    }
}