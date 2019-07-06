using System.ComponentModel;

namespace Agents.Finances.Domain.Enums {
    /// <summary>
    /// 交易类型
    /// </summary>
    public enum TradeType {
        /// <summary>
        /// 佣金
        /// </summary>
        [Description("佣金")]
        Commission = 0,
        /// <summary>
        /// 提现
        /// </summary>
        [Description("提现")]
        OutCash = 1,
    }


}
