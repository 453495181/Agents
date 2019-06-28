using System;
using Agents.Agents.Domain.Models;

namespace Agents.Members.Domain.Models {
    /// <summary>
    /// 会员
    /// </summary>
    public partial class Member {

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init() {
            base.Init();
            FirstTime = DateTime.Now;
            RegisterTime = DateTime.Now;
        }

        /// <summary>
        /// 设置代理
        /// </summary>
        public void SetAgent(Agent agent) {
            AgentId = agent.Id;
            AgentPath = agent.AgentPath;
        }
    }
}