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
    /// 账户服务
    /// </summary>
    public class AccountService : CrudServiceBase<Account, AccountDto, AccountQuery>, IAccountService {
        /// <summary>
        /// 初始化账户服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="accountRepository">账户仓储</param>
        public AccountService( IAgentsUnitOfWork unitOfWork, IAccountRepository accountRepository )
            : base( unitOfWork, accountRepository ) {
            AccountRepository = accountRepository;
        }
        
        /// <summary>
        /// 账户仓储
        /// </summary>
        public IAccountRepository AccountRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Account> CreateQuery( AccountQuery param ) {
            return new Query<Account>( param );
        }
    }
}