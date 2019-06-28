
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;

namespace Agents.Agents.Domain.Services.Abstractions {
    /// <summary>
    /// 代理管理器
    /// </summary>
    public interface IAgentManager {

        /// <summary>
        /// 添加代理
        /// </summary>
        Task<Agent> CreateAgentAsync(Agent model);

        /// <summary>
        /// 审批代理
        /// </summary>
        Task ApprovalAgentAsync(Agent agent);

        /// <summary>
        /// 拒绝审批代理
        /// </summary>
        void RefuseAgent(Agent agent);

        /// <summary>
        /// 申请代理
        /// </summary>
        Task ApplyAgentAsync(Agent model);

        /// <summary>
        /// 删除用户
        /// </summary>
        Task DeleteAgents(string ids);

        /// <summary>
        /// 获取当前登陆代理 如果当前登陆的不是代理 返回Null
        /// </summary>
        Agent GetCurrentAgentAsync();
    }
}