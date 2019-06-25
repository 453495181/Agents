using System;
using Util.Exceptions;

namespace Agents.Agents.Domain.Models {
    /// <summary>
    /// 代理
    /// </summary>
    public partial class Agent {

        /// <summary>
        /// 通过审核
        /// </summary>
        public void Approval() {
            if (State != Enums.AgentState.WatiApproval) {
                throw new Warning("该状态不支持此操作");
            }
            State = Enums.AgentState.Approved;
        }
        /// <summary>
        /// 拒绝审核
        /// </summary>
        public void Refuse() {
            if (State != Enums.AgentState.WatiApproval) {
                throw new Warning("该状态不支持此操作");
            }
            State = Enums.AgentState.UnApproved;
        }
    }
}