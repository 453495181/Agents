using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Members {
    /// <summary>
    /// 会员仓储
    /// </summary>
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository {
        /// <summary>
        /// 初始化会员仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MemberRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}