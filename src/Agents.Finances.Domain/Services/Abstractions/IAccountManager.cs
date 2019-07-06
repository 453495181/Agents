
using System;
using System.Threading.Tasks;
using Agents.Finances.Domain.Enums;
using Agents.Finances.Domain.Models;

namespace Agents.Finances.Domain.Services.Abstractions {
    /// <summary>
    /// 账户管理器
    /// </summary>
    public interface IAccountManager {

        /// <summary>
        /// 创建账户
        /// </summary>
        Task CreateAccountAsync(Guid accountId);

        /// <summary>
        /// 删除账户
        /// </summary>
        Task DeleteAccountAsync(string ids);

        /// <summary>
        /// 账户加款
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        Task AddMoneyAsync(Guid accountId, decimal money, TradeType tradeType, string businessId, string note);

        /// <summary>
        /// 账户扣款
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        Task DeductionMoneyAsync(Guid accountId, decimal money, TradeType tradeType, string businessId, string note);

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="outAccountId">打款账户编号</param>
        /// <param name="inAccountId">收款账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        Task TransferAsync(Guid outAccountId, Guid inAccountId, decimal money, TradeType tradeType, string businessId, string note);


        /// <summary>
        /// 冻结余额
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        Task FreezeBalanceAsync(Guid accountId, decimal money);

        /// <summary>
        /// 解冻余额
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        Task UnFreezeBalanceAsync(Guid accountId, decimal money);
    }
}