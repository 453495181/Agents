using System;
using System.Linq.Expressions;
using Agents.Agents.Domain.Models;
using Agents.Distributions.Domain.Models;
using Util;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Distributions {
    /// <summary>
    /// 佣金查询规约
    /// </summary>
    public class CommissionQueryCondition : ICriteria<Commission> {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="currentAgent">当前登陆代理</param>
        public CommissionQueryCondition(Agent currentAgent) {
            CurrentAgent = currentAgent;
        }

        private Agent CurrentAgent { get; }

        public Expression<Func<Commission, bool>> GetPredicate() {
            Expression<Func<Commission, bool>> result = null;
            if (CurrentAgent != null) {
                var agentId = CurrentAgent.Id;
                result = t => t.AgentId == agentId;
            }
            return result;
        }
    }
}