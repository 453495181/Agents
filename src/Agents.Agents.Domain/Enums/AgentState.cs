using System.ComponentModel;
using Util;

namespace Agents.Agents.Domain.Enums {
    /// <summary>
    /// 代理审批状态
    /// </summary>
    public enum AgentState {
        /// <summary>
        /// 待审批
        /// </summary>
        [Description("待审批")]
        WatiApproval = 0,

        /// <summary>
        /// 通过
        /// </summary>
        [Description("通过")]
        Approved = 1,

        /// <summary>
        /// 未通过
        /// </summary>
        [Description("未通过")]
        UnApproved = 2,
    }
}
