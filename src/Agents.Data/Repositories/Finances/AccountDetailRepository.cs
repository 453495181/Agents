using Agents.Finances.Domain.Models;
using Agents.Finances.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Finances {
    /// <summary>
    /// 账户明细仓储
    /// </summary>
    public class AccountDetailRepository : RepositoryBase<AccountDetail>, IAccountDetailRepository {
        /// <summary>
        /// 初始化账户明细仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AccountDetailRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}