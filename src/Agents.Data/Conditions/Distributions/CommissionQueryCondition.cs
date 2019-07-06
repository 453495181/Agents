using System;
using System.Linq.Expressions;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;
using Util.Domains.Repositories;

namespace Agents.Data.Conditions.Distributions {
    /// <summary>
    /// 佣金仓储
    /// </summary>
    public class CommissionRepository : RepositoryBase<Commission>, ICommissionRepository {
        /// <summary>
        /// 初始化佣金仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public CommissionRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
	/// <summary>
    /// 佣金查询规约
    /// </summary>
    public class CommissionQueryCondition : ICriteria<Commission> {

        /// <summary>
        /// 构造函数
        /// </summary>
        public CommissionQueryCondition() {
        }

        public Expression<Func<Commission, bool>> GetPredicate() {
            Expression<Func<Commission, bool>> result = null;
            return result;
        }
    }
}