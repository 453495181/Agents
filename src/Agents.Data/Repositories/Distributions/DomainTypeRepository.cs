using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Distributions {
    /// <summary>
    /// 域名分类仓储
    /// </summary>
    public class DomainTypeRepository : RepositoryBase<DomainType>, IDomainTypeRepository {
        /// <summary>
        /// 初始化域名分类仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DomainTypeRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}