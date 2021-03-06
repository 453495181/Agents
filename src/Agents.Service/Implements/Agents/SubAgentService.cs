﻿using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Data;
using Agents.Service.Abstractions.Agents;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Extensions;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using System;
using System.Threading.Tasks;
using Util.Applications;
using Util.Datas.Queries;
using Util.Domains.Repositories;
using Util.Maps;

namespace Agents.Service.Implements.Agents
{
    /// <summary>
    /// 代理服务
    /// </summary>
    public class SubAgentService : CrudServiceBase<Agent, AgentDto, SubAgentQuery>, ISubAgentService
    {
        /// <summary>
        /// 初始化代理服务
        /// </summary>
        public SubAgentService(IAgentsUnitOfWork unitOfWork, IAgentRepository agentRepository, IAgentManager agentManager)
            : base(unitOfWork, agentRepository)
        {
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
        protected override IQueryBase<Agent> CreateQuery(SubAgentQuery param)
        {
            return new Query<Agent>(param)
                .Where(t => t.ParentId == param.AgentId)
                .WhereIfNotEmpty(t => t.Code == param.Code)
                .WhereIfNotEmpty(t => t.Name.Contains(param.Name));
        }

        /// <summary>
        /// 添加代理
        /// </summary>
        public async Task<Guid> CreateAsync(AgentCreateRequest request)
        {
            var agent = request.MapTo<Agent>();
            agent = await AgentManager.CreateAgentAsync(agent);
            await UnitOfWork.CommitAsync();
            return agent.Id;
        }


        /// <summary>
        /// 异步获取代理
        /// </summary>
        public async Task<AgentDto> GetAgentByIdAsync(Guid agentId)
        {
            var agent = await AgentRepository.FindAsync(agentId);
            var result = agent.ToDto();
            if (agent.ParentId != null)
            {
                var parentAgent = await AgentRepository.FindAsync(agent.ParentId);
                result.ParentName = parentAgent.Name;
            }
            return result;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public async Task DeleteAgents(string ids)
        {
            await AgentManager.DeleteAgents(ids);
            await UnitOfWork.CommitAsync();
        }

        public async Task UpdateAgentAsync(AgentUpdateRequest request)
        {
            var entity = await AgentRepository.FindAsync(request.Id);
            request.MapTo(entity);

            await AgentRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }
    }
}