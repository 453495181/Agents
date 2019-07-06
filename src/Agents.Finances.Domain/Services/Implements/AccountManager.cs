using System;
using System.Threading.Tasks;
using Agents.Finances.Domain.Enums;
using Agents.Finances.Domain.Models;
using Agents.Finances.Domain.Repositories;
using Agents.Finances.Domain.Services.Abstractions;
using Util.Domains.Services;

namespace Agents.Finances.Domain.Services.Implements {
    /// <summary>
    /// 账户管理器
    /// </summary>
    public class AccountManager : DomainServiceBase, IAccountManager {
        /// <summary>
        /// 账户仓储
        /// </summary>
        private IAccountRepository AccountRepository;

        public IAccountDetailRepository AccountDetailRepository { get; }

        /// <summary>
        /// 初始化账户管理器
        /// </summary>
        public AccountManager(IAccountRepository accountRepository, IAccountDetailRepository accountDetailRepository) {
            AccountRepository = accountRepository;
            AccountDetailRepository = accountDetailRepository;
        }

        /// <summary>
        /// 创建账户
        /// </summary>
        public async Task CreateAccountAsync(Guid accountId) {
            var account = new Account(accountId);
            account.Init();
            account.Enabled = true;
            account.Validate();
            await AccountRepository.AddAsync(account);
        }

        /// <summary>
        /// 删除账户
        /// </summary>
        public async Task DeleteAccountAsync(string ids) {
            var entitis = await AccountRepository.FindByIdsAsync(ids);
            await AccountRepository.RemoveAsync(entitis);
        }

        /// <summary>
        /// 账户加款
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        public async Task AddMoneyAsync(Guid accountId, decimal money, TradeType tradeType, string businessId, string note) {
            var account = await AccountRepository.FindAsync(accountId);
            var accountDetail = account.ModifyMoney(money, tradeType, businessId, note);
            await AccountRepository.UpdateAsync(account);
            await AccountDetailRepository.AddAsync(accountDetail);
        }

        /// <summary>
        /// 账户扣款
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        public async Task DeductionMoneyAsync(Guid accountId, decimal money, TradeType tradeType, string businessId, string note) {
            var account = await AccountRepository.FindAsync(accountId);
            var accountDetail = account.ModifyMoney(-money, tradeType, businessId, note);
            await AccountRepository.UpdateAsync(account);
            await AccountDetailRepository.AddAsync(accountDetail);
        }

        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="outAccountId">打款账户编号</param>
        /// <param name="inAccountId">收款账户编号</param>
        /// <param name="money">金额</param>
        /// <param name="tradeType">交易类型</param>
        /// <param name="businessId">业务编号</param>
        /// <param name="note">备注</param>
        public async Task TransferAsync(Guid outAccountId, Guid inAccountId, decimal money, TradeType tradeType, string businessId, string note) {
            await DeductionMoneyAsync(outAccountId, money, tradeType, businessId, note);
            await AddMoneyAsync(inAccountId, money, tradeType, businessId, note);
        }

        /// <summary>
        /// 冻结余额
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        public async Task FreezeBalanceAsync(Guid accountId, decimal money) {
            var account = await AccountRepository.FindAsync(accountId);
            account.BalanceFreeze(money);
            await AccountRepository.UpdateAsync(account);
        }

        /// <summary>
        /// 解冻余额
        /// </summary>
        /// <param name="accountId">账户编号</param>
        /// <param name="money">金额</param>
        public async Task UnFreezeBalanceAsync(Guid accountId, decimal money) {
            var account = await AccountRepository.FindAsync(accountId);
            account.BalanceUnFreeze(money);
            await AccountRepository.UpdateAsync(account);
        }
    }
}
