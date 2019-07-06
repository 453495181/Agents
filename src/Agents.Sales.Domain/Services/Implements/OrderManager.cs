
using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;
using Agents.Sales.Domain.Models;
using Agents.Sales.Domain.Repositories;
using Agents.Sales.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Sales.Domain.Services.Implements {
    /// <summary>
    /// 订单管理器
    /// </summary>
    public class OrderManager : DomainServiceBase, IOrderManager {

        /// <summary>
        /// 初始化订单管理器
        /// </summary>
        public OrderManager(IOrderRepository orderRepository) {
            OrderRepository = orderRepository;
        }

        /// <summary>
        /// 订单仓储
        /// </summary>
        public IOrderRepository OrderRepository { get; set; }

        /// <summary>
        /// 添加订单
        /// </summary>
        public async Task<Order> CreateOrderAsync(Order model, Member member) {
            model.Init();
            model.SetMemberInfo(member);
            await OrderRepository.AddAsync(model);
            return model;
        }

        /// <summary>
        /// 添加订单
        /// </summary>
        public void PayOrder(Order model) {
            model.Pay();
        }
    }
}