﻿using System;
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
        /// 异步获取代理
        /// </summary>
        Task<AgentDto> GetAgentByIdAsync(Guid guid);

        /// <summary>
        /// 添加代理
        /// </summary>
        Task<Guid> CreateAsync(AgentCreateRequest request);

        /// <summary>
        /// 修改代理
        /// </summary>
        Task UpdateAsync(AgentUpdateRequest request);

        /// <summary>
        /// 删除代理
        /// </summary>
        Task DeleteAgents(string ids);
    }
}