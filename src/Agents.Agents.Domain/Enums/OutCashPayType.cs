using System.ComponentModel;

namespace Agents.Agents.Domain.Enums
{
    public enum OutCashPayType
    {
        /// <summary>
        /// 支付宝
        /// </summary>
        [Description("支付宝")] Alipay = 0,

        /// <summary>
        /// 银行卡
        /// </summary>
        [Description("银行卡")] Bank = 1,
    }
}
