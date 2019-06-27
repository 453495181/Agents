using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Agents.Domain.Services.Requests;
using Agents.Finances.Domain.Services.Abstractions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Util;
using Util.Domains.Services;

namespace Agents.Agents.Domain.Services.Implements
{
    /// <summary>
    /// 代理管理器
    /// </summary>
    public class AgentManager : DomainServiceBase, IAgentManager
    {
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
        public AgentManager(IAgentRepository agentRepository, IAccountManager accountManager, IUserManager userManager)
        {
            AgentRepository = agentRepository;
            AccountManager = accountManager;
            UserManager = userManager;
        }

        /// <summary>
        /// 添加代理
        /// </summary>
        public async Task<Agent> CreateAgentAsync(Agent model)
        {
            var agent = await AddAgent(model);
            await ApprovalAgentAsync(agent);
            return agent;
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        private async Task<Agent> AddAgent(Agent agent)
        {
            //var maxCode = await AgentRepository.Find(t => true).MaxAsync(t => t.Code);
            var maxCode = await AgentRepository.GetMaxCode();

            agent.Init();
            agent.SetCode(maxCode);
            agent.SetAgentPath("");
            await AgentRepository.AddAsync(agent);
            return agent;
        }

        /// <summary>
        /// 审批代理
        /// </summary>
        public async Task ApprovalAgentAsync(Agent agent)
        {
            var userId = await UserManager.CraeteUser(new CreateUserRequest(agent.Mobile, agent.Email, agent.Mobile, agent.Mobile.Substring(5, 6)));
            agent.Approval(userId);
            await AccountManager.CreateAccount(agent.Id);
        }

        /// <summary>
        /// 拒绝审批代理
        /// </summary>
        public void RefuseAgent(Agent agent)
        {
            agent.Refuse();
        }

        /// <summary>
        /// 申请代理
        /// </summary>
        public async Task ApplyAgentAsync(Agent model)
        {
            await AddAgent(model);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public async Task DeleteAgents(string ids)
        {
            var agents = await AgentRepository.FindByIdsAsync(ids);
            await UserManager.DeleteUser(agents.Where(t => t.UserId.HasValue).Select(t => t.UserId.Value).Join(","));
            await AgentRepository.RemoveAsync(agents);
        }

        public async Task<string> GetParentPath(Guid parentId)
        {
            var entity = await AgentRepository.FindAsync(parentId);
            var path = entity.AgentPath;
            if (string.IsNullOrEmpty(path))
            {
                return parentId.ToString();
            }

            //只要3级代理
            var p = path.Split(',').ToList();
            var list = p;
            if (p.Count >= 3)
            {
                list = p.GetRange(p.Count - 2, 2);
            }

            return list.Join(",")+","+ parentId.ToString();
        }

    }
}
