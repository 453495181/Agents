
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
        Task AddAgent(Agent model, string pwd, string pwdAgain);
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
        Task ApplyAgent(Agent model, string pwd, string pwdAgain);
    }
}