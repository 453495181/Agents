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
        public async Task AddAgent(Agent model, string pwd, string pwdAgain) {
            var agent = await CreateAgent(model, pwd, pwdAgain);
            agent.Approval();
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        private async Task<Agent> CreateAgent(Agent agent, string pwd, string pwdAgain) {
            await UserManager.CraeteUser(agent.Email, pwd, pwdAgain);
            agent.Init();
            agent.SetAgentPath("");
            await AccountManager.CreateAccount(agent.Id);
            await AgentRepository.AddAsync(agent);
            return agent;
        }

        /// <summary>
        /// 审批代理
        /// </summary>
        public void ApprovalAgent(Agent agent) {
            agent.Approval();
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
        public async Task ApplyAgent(Agent model, string pwd, string pwdAgain) {
            await CreateAgent(model, pwd, pwdAgain);
        }
    }
}
