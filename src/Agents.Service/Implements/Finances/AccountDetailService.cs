using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Finances.Domain.Models;
using Agents.Finances.Domain.Repositories;
using Agents.Service.Dtos.Finances;
using Agents.Service.Queries.Finances;
using Agents.Service.Abstractions.Finances;

namespace Agents.Service.Implements.Finances {
    /// <summary>
    /// 账户明细服务
    /// </summary>
    public class AccountDetailService : CrudServiceBase<AccountDetail, AccountDetailDto, AccountDetailQuery>, IAccountDetailService {
        /// <summary>
        /// 初始化账户明细服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="accountDetailRepository">账户明细仓储</param>
        public AccountDetailService( IAgentsUnitOfWork unitOfWork, IAccountDetailRepository accountDetailRepository )
            : base( unitOfWork, accountDetailRepository ) {
            AccountDetailRepository = accountDetailRepository;
        }
        
        /// <summary>
        /// 账户明细仓储
        /// </summary>
        public IAccountDetailRepository AccountDetailRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<AccountDetail> CreateQuery( AccountDetailQuery param ) {
            return new Query<AccountDetail>( param );
        }
    }
}