using System.ComponentModel;

namespace Agents.Distributions.Domain.Enums {
    /// <summary>
    /// 佣金状态
    /// </summary>
    public enum CommissionState {
        /// <summary>
        /// 未支付
        /// </summary>
        [Description("未支付")]
        UnPayed = 0,
        /// <summary>
        /// 已支付
        /// </summary>
        [Description("已支付")]
        Payed = 1,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Cancle = 2,
    }
}
