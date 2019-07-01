using System.ComponentModel;

namespace Agents.Sales.Domain.Enums {
    /// <summary>
    /// 支付类型
    /// </summary>
    public enum PayType {
        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")]
        AliPay = 0,
    }
}
