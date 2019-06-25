using Util.Applications;
using Agents.Service.Dtos.Finances;
using Agents.Service.Queries.Finances;

namespace Agents.Service.Abstractions.Finances {
    /// <summary>
    /// 账户明细服务
    /// </summary>
    public interface IAccountDetailService : ICrudService<AccountDetailDto, AccountDetailQuery> {
    }
}