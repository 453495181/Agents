using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Sales;
using Agents.Service.Dtos.Sales.Requests;
using Agents.Service.Queries.Sales;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Sales {
    /// <summary>
    /// 订单服务
    /// </summary>
    public interface IOrderService : IDeleteService<OrderDto, OrderQuery> {

        /// <summary>
        /// 分页查询
        /// </summary>
        Task<PagerList<OrderDto>> PagerQueryOrderAsync(OrderQuery parameter);

        /// <summary>
        /// 异步获取订单
        /// </summary>
        Task<OrderDto> GetOrderByIdAsync(Guid guid);

        /// <summary>
        /// 添加订单
        /// </summary>
        Task<Guid> CreateAsync(OrderCreateRequest request);

        /// <summary>
        /// 修改订单
        /// </summary>
        Task PayAsync(Guid orderId);

        /// <summary>
        /// 修改订单
        /// </summary>
        Task UpdateAsync(OrderUpdateRequest request);

        /// <summary>
        /// 删除订单
        /// </summary>
        Task DeleteOrder(string ids);

    }
}