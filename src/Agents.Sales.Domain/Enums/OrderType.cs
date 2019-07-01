using System.ComponentModel;

namespace Agents.Sales.Domain.Enums {
    /// <summary>
    /// 订单类型
    /// </summary>
    public enum OrderType {
        /// <summary>
        /// App
        /// </summary>
        [Description("App")]
        App = 0,

        /// <summary>
        /// Web
        /// </summary>
        [Description("Web")]
        Web = 1,
    }
}
