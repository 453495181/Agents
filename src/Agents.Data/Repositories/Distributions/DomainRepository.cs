using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Distributions {
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
}