using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Agents {
    /// <summary>
    /// 代理仓储
    /// </summary>
    public class AgentRepository : RepositoryBase<Agent>, IAgentRepository {
        /// <summary>
        /// 初始化代理仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AgentRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}