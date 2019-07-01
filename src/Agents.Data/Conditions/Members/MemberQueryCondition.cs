using System;
using System.Linq.Expressions;
using Agents.Agents.Domain.Models;
using Agents.Members.Domain.Models;
using Util;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Members {

    /// <summary>
    /// 会员查询规约
    /// </summary>
    public class MemberQueryCondition : ICriteria<Member> {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="currentAgent">当前登陆代理</param>
        public MemberQueryCondition(Agent currentAgent) {
            CurrentAgent = currentAgent;
        }

        private Agent CurrentAgent { get; }

        public Expression<Func<Member, bool>> GetPredicate() {
            Expression<Func<Member, bool>> result = null;
            if (CurrentAgent != null) {

                var agentId = CurrentAgent.Id.SafeString();
                result = t => t.AgentPath.Contains(agentId);
            }
            return result;
        }
    }
}
