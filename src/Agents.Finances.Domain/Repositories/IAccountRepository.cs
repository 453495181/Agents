using Util.Domains.Repositories;
using Agents.Finances.Domain.Models;

namespace Agents.Finances.Domain.Repositories {
    /// <summary>
    /// 账户仓储
    /// </summary>
    public interface IAccountRepository : IRepository<Account> {
    }
}