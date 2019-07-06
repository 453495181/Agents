using System.ComponentModel;

namespace Agents.Distributions.Domain.Enums {
    /// <summary>
    /// 佣金类型
    /// </summary>
    public enum CommissionType {
        /// <summary>
        /// 一级佣金
        /// </summary>
        [Description("一级佣金")]
        Level1 = 0,
        /// <summary>
        /// 二级佣金
        /// </summary>
        [Description("二级佣金")]
        Level2 = 1,
        /// <summary>
        /// 三级佣金
        /// </summary>
        [Description("三级佣金")]
        Level3 = 2,
    }
}
