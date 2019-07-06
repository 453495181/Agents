using Agents.Agents.Domain.Models;
using Agents.Sales.Domain.Models;
using System;
using System.Linq.Expressions;
using Util;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Sales {

    /// <summary>
    /// 订单查询规约
    /// </summary>
    public class OrderQueryCondition : ICriteria<Order> {

        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderQueryCondition(Agent currentAgent) {
            CurrentAgent = currentAgent;
        }

        private Agent CurrentAgent { get; }

        public Expression<Func<Order, bool>> GetPredicate() {
            Expression<Func<Order, bool>> result = null;
            if (CurrentAgent != null) {
                var agentId = CurrentAgent.Id.SafeString();
                result = t => t.Member.AgentPath.Contains(agentId);
            }
            return result;
        }
    }
}