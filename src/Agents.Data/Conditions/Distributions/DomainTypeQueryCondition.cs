using System;
using System.Linq.Expressions;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Distributions {
	/// <summary>
    /// 域名分类查询规约
    /// </summary>
    public class DomainTypeQueryCondition : ICriteria<DomainType> {

        /// <summary>
        /// 构造函数
        /// </summary>
        public DomainTypeQueryCondition() {
        }

        public Expression<Func<DomainType, bool>> GetPredicate() {
            Expression<Func<DomainType, bool>> result = null;
            return result;
        }
    }
}