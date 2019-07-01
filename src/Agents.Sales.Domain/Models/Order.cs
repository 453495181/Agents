using System;

namespace Agents.Sales.Domain.Models {
    /// <summary>
    /// 订单
    /// </summary>
    public partial class Order {

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init() {
            State = Enums.OrderState.WaitPay;
            OrderTime = DateTime.Now;
        }
    }
}