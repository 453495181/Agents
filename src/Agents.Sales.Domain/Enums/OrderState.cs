using System.ComponentModel;

namespace Agents.Sales.Domain.Enums {
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderState {
        /// <summary>
        /// 待支付
        /// </summary>
        [Description("WaitPay")]
        WaitPay = 0,

        /// <summary>
        /// 已支付
        /// </summary>
        [Description("已支付")]
        Payed = 1,
        /// <summary>
        /// 支付失败
        /// </summary>
        [Description("支付失败")]
        PayFail = 2,
    }
}
