using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Agents.Agents.Domain.Models;
using Agents.Members.Domain.Models;
using Util;
using Util.Datas.Queries;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions {
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

                var agentCode = CurrentAgent.Code.SafeString();
                result = t => t.AgentPath.Contains(agentCode);
            }
            return result;
        }
    }
}
