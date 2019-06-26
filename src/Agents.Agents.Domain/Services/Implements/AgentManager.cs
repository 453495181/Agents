using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Finances.Domain.Services.Abstractions;
using Util.Domains.Services;

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
            agent.Approval();
            return agent;
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        private async Task<Agent> AddAgent(Agent agent) {
            agent.Init();
            agent.SetAgentPath("");
            await AgentRepository.AddAsync(agent);
            return agent;
        }

        /// <summary>
        /// 审批代理
        /// </summary>
        public async Task ApprovalAgentAsync(Agent agent) {
            agent.Approval();
            await UserManager.CraeteUser(agent.Mobile, agent.Mobile.Substring(5, 6));
            await AccountManager.CreateAccount(agent.Id);
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
    }
}
