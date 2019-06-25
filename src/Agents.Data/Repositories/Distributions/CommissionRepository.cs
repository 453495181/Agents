using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Distributions {
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
}