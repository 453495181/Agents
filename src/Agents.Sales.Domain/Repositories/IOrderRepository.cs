using Util.Domains.Repositories;
using Agents.Sales.Domain.Models;

namespace Agents.Sales.Domain.Repositories {
    /// <summary>
    /// 订单仓储
    /// </summary>
    public interface IOrderRepository : IRepository<Order> {
    }
}