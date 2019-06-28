using Util.Applications;
using Agents.Service.Dtos.Finances;
using Agents.Service.Queries.Finances;
using System;
using System.Threading.Tasks;

namespace Agents.Service.Abstractions.Finances {
    /// <summary>
    /// 账户服务
    /// </summary>
    public interface IAccountService : ICrudService<AccountDto, AccountQuery>
    {
       
    }
}