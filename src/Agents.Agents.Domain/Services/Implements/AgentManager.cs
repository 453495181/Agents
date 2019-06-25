using System;
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
        /// 初始化代理管理器
        /// </summary>
        /// <param name="agentRepository">代理仓储</param>
        public AgentManager(IAgentRepository agentRepository, IAccountManager accountManager) {
            AgentRepository = agentRepository;
            AccountManager = accountManager;
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        public void AddAgent(Agent model) {
            var agent = CreateAgent(model);
            agent.Approval();
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        private Agent CreateAgent(Agent agent) {
            agent.Init();
            //获取当前代理 设置代理路径
            //ToDo
            agent.Enabled = true;
            agent.State = Enums.AgentState.WatiApproval;
            agent.Validate();
            AccountManager.CreateAccount(agent.Id);
            //创建用户
            //ToDo
            AgentRepository.Add(agent);
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
        public void ApplyAgent(Agent model) {
            CreateAgent(model);
        }
    }
}
