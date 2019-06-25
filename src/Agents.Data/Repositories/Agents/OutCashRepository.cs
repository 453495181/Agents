using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Agents {
    /// <summary>
    /// 提现仓储
    /// </summary>
    public class OutCashRepository : RepositoryBase<OutCash>, IOutCashRepository {
        /// <summary>
        /// 初始化提现仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public OutCashRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}