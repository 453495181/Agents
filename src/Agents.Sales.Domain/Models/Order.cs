using System;
using Agents.Members.Domain.Models;
using Agents.Sales.Domain.Enums;
using Util.Exceptions;

namespace Agents.Sales.Domain.Models {
    /// <summary>
    /// 订单
    /// </summary>
    public partial class Order {

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init() {
            State = OrderState.WaitPay;
            CommissionState = OrderCommissionState.WaitCalculation;
            OrderTime = DateTime.Now;
            base.Init();
        }

        /// <summary>
        /// 设置会员信息
        /// </summary>
        public void SetMemberInfo(Member member) {
            MemberId = member.Id;
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        public void Pay() {
            State = OrderState.Payed;
            PayTime = DateTime.Now;
        }

        /// <summary>
        /// 支付订单佣金
        /// </summary>
        public void PayCommission() {
            if (CommissionState != OrderCommissionState.WaitPay) {
                throw new Warning("错误的订单状态");
            }
            CommissionState = OrderCommissionState.Payed;
        }
    }
}