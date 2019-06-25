using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;

namespace Agents.Service.Implements.Agents {
    /// <summary>
    /// 代理服务
    /// </summary>
    public class AgentService : CrudServiceBase<Agent, AgentDto, AgentQuery>, IAgentService {
        /// <summary>
        /// 初始化代理服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="agentRepository">代理仓储</param>
        public AgentService( IAgentsUnitOfWork unitOfWork, IAgentRepository agentRepository )
            : base( unitOfWork, agentRepository ) {
            AgentRepository = agentRepository;
        }
        
        /// <summary>
        /// 代理仓储
        /// </summary>
        public IAgentRepository AgentRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Agent> CreateQuery( AgentQuery param ) {
            return new Query<Agent>( param );
        }
    }
}