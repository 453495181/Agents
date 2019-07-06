using System;
using Agents.Finances.Domain.Enums;
using Util;
using Util.Exceptions;
using Util.Validations;

namespace Agents.Finances.Domain.Models {
    /// <summary>
    /// 账户
    /// </summary>
    public partial class Account {
        /// <summary>
        /// 变更金额
        /// </summary>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        public AccountDetail ModifyMoney(decimal money, TradeType tradeType, string businessId, string note) {
            var accountDetail = new AccountDetail() {
                AccountId = Id,
                BeforeBalance = Balance,
                AfterBalance = GetAfterBalance(money),
                TradeType = tradeType.Description(),
                TradeTime = DateTime.Now,
                TradeMoney = money,
                BusinessId = businessId,
                Note = note
            };
            accountDetail.Init();
            Balance = GetAfterBalance(money);
            Validate();
            accountDetail.Validate();
            return accountDetail;
        }
        /// <summary>
        /// 获取交易后余额
        /// </summary>
        private decimal GetAfterBalance(decimal money) {
            return Balance + money;
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public override ValidationResultCollection Validate() {
            if (Balance < 0) {
                throw new Warning("余额不足！");
            }
            if (FreezeBalance.SafeValue() < 0) {
                throw new Warning("冻结金额不能小于0！");
            }
            return base.Validate();
        }

        /// <summary>
        /// 冻结余额
        /// </summary>
        public void BalanceFreeze(decimal money) {
            Balance -= money;
            FreezeBalance += money;
            Validate();
        }

        /// <summary>
        /// 解冻余额
        /// </summary>
        public void BalanceUnFreeze(decimal money) {
            Balance += money;
            FreezeBalance -= money;
            Validate();
        }
    }
}