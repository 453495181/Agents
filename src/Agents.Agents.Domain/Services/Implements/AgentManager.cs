﻿using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Agents.Domain.Services.Requests;
using Agents.Finances.Domain.Services.Abstractions;
using System.Linq;
using System.Threading.Tasks;
using Util;
using Util.Domains.Services;
using Util.Security;

namespace Agents.Agents.Domain.Services.Implements {
    /// <summary>
    /// 代理管理器
    /// </summary>
    public class AgentManager : DomainServiceBase, IAgentManager {
        /// <summary>
        /// 代理仓储
        /// </summary>
        private IAgentRepository AgentRepository;

        /// <summary>
        /// 账户管理器
        /// </summary>
        private IAccountManager AccountManager;

        /// <summary>
        /// 用户管理器
        /// </summary>
        private IUserManager UserManager;

        /// <summary>
        /// 初始化代理管理器
        /// </summary>
        public AgentManager(IAgentRepository agentRepository, IAccountManager accountManager, IUserManager userManager) {
            AgentRepository = agentRepository;
            AccountManager = accountManager;
            UserManager = userManager;
        }

        /// <summary>
        /// 添加代理
        /// </summary>
        public async Task<Agent> CreateAgentAsync(Agent model) {
            var agent = await AddAgent(model);
            await ApprovalAgentAsync(agent);
            return agent;
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        private async Task<Agent> AddAgent(Agent agent) {
            var maxCode = await AgentRepository.GetMaxCode();
            agent.Init();
            agent.SetCode(maxCode);
            agent.SetAgentPath(await GetCurrentAgentAsync());
            await AgentRepository.AddAsync(agent);
            return agent;
        }

        /// <summary>
        /// 审批代理
        /// </summary>
        public async Task ApprovalAgentAsync(Agent agent) {
            var userId = await UserManager.CraeteUser(new CreateUserRequest(agent.Mobile, agent.Email, agent.Mobile, agent.Mobile.Substring(5, 6)));
            agent.Approval(userId);
            await AccountManager.CreateAccountAsync(agent.Id);
        }

        /// <summary>
        /// 拒绝审批代理
        /// </summary>
        public void RefuseAgent(Agent agent) {
            agent.Refuse();
        }

        /// <summary>
        /// 申请代理
        /// </summary>
        public async Task ApplyAgentAsync(Agent model) {
            await AddAgent(model);
        }

        /// <summary>
        /// 删除代理
        /// </summary>
        public async Task DeleteAgents(string ids) {
            var agents = await AgentRepository.FindByIdsAsync(ids);
            await UserManager.DeleteUser(agents.Where(t => t.UserId.HasValue).Select(t => t.UserId.Value).Join(","));
            await AccountManager.DeleteAccountAsync(agents.Select(t => t.Id).Join(","));
            await AgentRepository.RemoveAsync(agents);
        }

        /// <summary>
        /// 获取当前登陆代理 如果当前登陆的不是代理 返回Null
        /// </summary>
        public async Task<Agent> GetCurrentAgentAsync() {
            var currentUserId = Session.GetUserId();
            var agent = await AgentRepository.SingleAsync(t => t.UserId == currentUserId);
            return agent;
        }
    }
}
