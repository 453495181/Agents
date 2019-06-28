using System;
using System.Threading.Tasks;
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

        /// <summary>
        /// 初始化账户管理器
        /// </summary>
        /// <param name="accountRepository">账户仓储</param>
        public AccountManager(IAccountRepository accountRepository) {
            AccountRepository = accountRepository;
        }

        /// <summary>
        /// 创建账户
        /// </summary>
        public async Task CreateAccount(Guid accountId) {
            var account = new Account(accountId);
            account.Init();
            account.Enabled = true;
            account.Validate();
            await AccountRepository.AddAsync(account);
        }

        /// <summary>
        /// 删除账户
        /// </summary>
        public async Task DeleteAccount(string ids) {
            var entitis = await AccountRepository.FindByIdsAsync(ids);
            await AccountRepository.RemoveAsync(entitis);
        }

    }
}
