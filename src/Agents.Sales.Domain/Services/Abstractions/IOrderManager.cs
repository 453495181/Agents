
using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;
using Agents.Sales.Domain.Models;

namespace Agents.Sales.Domain.Services.Abstractions {
    /// <summary>
    /// 订单管理器
    /// </summary>
    public interface IOrderManager {

        /// <summary>
        /// 添加订单
        /// </summary>
        Task<Order> CreateOrderAsync(Order model, Member member);

        /// <summary>
        /// 支付订单
        /// </summary>
        void PayOrder(Order model);
    }
}