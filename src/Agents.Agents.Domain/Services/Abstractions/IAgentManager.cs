
using System;
using Agents.Agents.Domain.Models;

namespace Agents.Agents.Domain.Services.Abstractions {
    /// <summary>
    /// 代理管理器
    /// </summary>
    public interface IAgentManager {
        /// <summary>
        /// 创建代理
        /// </summary>
        void AddAgent(Agent model);
        /// <summary>
        /// 审批代理
        /// </summary>
        void ApprovalAgent(Agent agent);
        /// <summary>
        /// 拒绝审批代理
        /// </summary>
        void RefuseAgent(Agent agent);
        /// <summary>
        /// 申请代理
        /// </summary>
        void ApplyAgent(Agent model);
    }
}