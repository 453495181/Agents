using System;
using System.Collections.Generic;
using System.Threading;
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
using System.Threading.Tasks;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Service.Dtos.Agents.Extensions;
using Agents.Service.Dtos.Agents.Requests;
using AspectCore.DynamicProxy.Parameters;
using Microsoft.EntityFrameworkCore;
using Util.Helpers;

namespace Agents.Service.Implements.Agents {
    /// <summary>
    /// 代理服务
    /// </summary>
    public class AgentService : CrudServiceBase<Agent, AgentDto, AgentQuery>, IAgentService {
        /// <summary>
        /// 初始化代理服务
        /// </summary>
        public AgentService(IAgentsUnitOfWork unitOfWork, IAgentRepository agentRepository, IAgentManager agentManager)
            : base(unitOfWork, agentRepository) {
            AgentRepository = agentRepository;
            AgentManager = agentManager;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// 代理仓储
        /// </summary>
        public IAgentRepository AgentRepository { get; set; }
        /// <summary>
        /// 代理管理器
        /// </summary>
        public IAgentManager AgentManager { get; set; }

        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Agent> CreateQuery(AgentQuery param) {
            return new Query<Agent>(param)
                .WhereIfNotEmpty(t => t.Code == param.Code)
                .WhereIfNotEmpty(t => t.Name.Contains(param.Name));
        }

        /// <summary>
        /// 异步获取代理
        /// </summary>
        public async Task<AgentDto> GetAgentByIdAsync(Guid agentId) {
            var agent = await AgentRepository.FindAsync(agentId);
            var result = agent.ToDto();
            if (agent.ParentId != null) {
                var parentAgent = await AgentRepository.FindAsync(agent.ParentId);
                result.ParentName = parentAgent.Name;
            }
            return result;
        }

        /// <summary>
        /// 添加代理
        /// </summary>
        public async Task<Guid> CreateAsync(AgentCreateRequest request) {
            var agent = request.MapTo<Agent>();
            agent = await AgentManager.CreateAgentAsync(agent);
            await UnitOfWork.CommitAsync();
            return agent.Id;
        }

        /// <summary>
        /// 修改代理
        /// </summary>
        public async Task UpdateAsync(AgentUpdateRequest request) {
            var entity = await AgentRepository.FindAsync(request.AgentId);
            request.MapTo(entity);
            await AgentRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public async Task DeleteAgents(string ids) {
            await AgentManager.DeleteAgents(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}