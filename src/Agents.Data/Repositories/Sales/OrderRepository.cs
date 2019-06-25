using Agents.Sales.Domain.Models;
using Agents.Sales.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Sales {
    /// <summary>
    /// 订单仓储
    /// </summary>
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository {
        /// <summary>
        /// 初始化订单仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public OrderRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}