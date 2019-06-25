using Util.Applications;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;

namespace Agents.Service.Abstractions.Agents {
    /// <summary>
    /// 代理服务
    /// </summary>
    public interface IAgentService : ICrudService<AgentDto, AgentQuery> {
    }
}