using System.ComponentModel;

namespace Agents.Sales.Domain.Enums {
    /// <summary>
    /// 订单佣金状态
    /// </summary>
    public enum OrderCommissionState {
        /// <summary>
        /// 未计算
        /// </summary>
        [Description("未计算")]
        WaitCalculation = 0,

        /// <summary>
        /// 待支付
        /// </summary>
        [Description("待支付")]
        WaitPay = 1,

        /// <summary>
        /// 已支付
        /// </summary>
        [Description("已支付")]
        Payed = 2
    }
}
