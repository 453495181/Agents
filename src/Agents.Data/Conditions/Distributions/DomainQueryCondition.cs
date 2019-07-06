using System;
using System.Linq.Expressions;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Distributions {
    /// <summary>
    /// 域名仓储
    /// </summary>
    public class DomainRepository : RepositoryBase<Domain>, IDomainRepository {
        /// <summary>
        /// 初始化域名仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DomainRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
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