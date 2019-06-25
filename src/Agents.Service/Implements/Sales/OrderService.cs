using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Sales.Domain.Models;
using Agents.Sales.Domain.Repositories;
using Agents.Service.Dtos.Sales;
using Agents.Service.Queries.Sales;
using Agents.Service.Abstractions.Sales;

namespace Agents.Service.Implements.Sales {
    /// <summary>
    /// 订单服务
    /// </summary>
    public class OrderService : CrudServiceBase<Order, OrderDto, OrderQuery>, IOrderService {
        /// <summary>
        /// 初始化订单服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="orderRepository">订单仓储</param>
        public OrderService( IAgentsUnitOfWork unitOfWork, IOrderRepository orderRepository )
            : base( unitOfWork, orderRepository ) {
            OrderRepository = orderRepository;
        }
        
        /// <summary>
        /// 订单仓储
        /// </summary>
        public IOrderRepository OrderRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Order> CreateQuery( OrderQuery param ) {
            return new Query<Order>( param );
        }
    }
}