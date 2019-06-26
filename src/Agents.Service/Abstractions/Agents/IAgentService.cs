using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;

namespace Agents.Service.Abstractions.Agents {
    /// <summary>
    /// 代理服务
    /// </summary>
    public interface IAgentService : ICrudService<AgentDto, AgentQuery> {

        /// <summary>
        /// 添加代理
        /// </summary>
        Task<Guid> CreateAsync(CreateAgentRequest request);
    }
}