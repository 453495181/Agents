using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Agents
{
    /// <summary>
    /// 提现服务
    /// </summary>
    public interface IOutCashService : ICrudService<OutCashDto, OutCashQuery>
    {

        /// <summary>
        /// 异步获取提现
        /// </summary>
        Task<OutCashDto> GetOutCashByIdAsync(Guid guid);

        /// <summary>
        /// 添加提现
        /// </summary>
        Task<Guid> CreateAsync(OutCashCreateRequest request);

        /// <summary>
        /// 修改提现
        /// </summary>
        Task UpdateAsync(OutCashUpdateRequest request);

        /// <summary>
        /// 删除提现
        /// </summary>
        Task DeleteOutCash(string ids);
        Task<PagerList<OutCashDto>> PagerQueryOutCashAsync(OutCashQuery query);
        Task AuditOutCash(string id);
    }
}