using Agents.Finances.Domain.Models;
using Agents.Finances.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Finances {
    /// <summary>
    /// 账户仓储
    /// </summary>
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository {
        /// <summary>
        /// 初始化账户仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AccountRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}