using Util.Applications;
using Agents.Service.Dtos.Sales;
using Agents.Service.Queries.Sales;

namespace Agents.Service.Abstractions.Sales {
    /// <summary>
    /// 订单服务
    /// </summary>
    public interface IOrderService : ICrudService<OrderDto, OrderQuery> {
    }
}