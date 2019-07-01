using System;
using System.Linq.Expressions;
using Agents.Sales.Domain.Models;
using Agents.Sales.Domain.Repositories;
using Util.Datas.Ef.Core;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Sales {
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
	/// <summary>
    /// 订单查询规约
    /// </summary>
    public class OrderQueryCondition : ICriteria<Order> {

        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderQueryCondition() {
        }

        public Expression<Func<Order, bool>> GetPredicate() {
            Expression<Func<Order, bool>> result = null;
            return result;
        }
    }
}