using System;
using System.Linq.Expressions;
using Agents.Distributions.Domain.Models;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Distributions {
	/// <summary>
    /// 域名查询规约
    /// </summary>
    public class DomainQueryCondition : ICriteria<Domain> {

        /// <summary>
        /// 构造函数
        /// </summary>
        public DomainQueryCondition() {
        }

        public Expression<Func<Domain, bool>> GetPredicate() {
            Expression<Func<Domain, bool>> result = null;
            return result;
        }
    }
}