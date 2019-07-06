using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Queries.Distributions;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 佣金服务
    /// </summary>
    public interface ICommissionService : IDeleteService<CommissionDto, CommissionQuery> {
	
        /// <summary>
        /// 分页查询
        /// </summary>
        Task<PagerList<CommissionDto>> PagerQueryCommissionAsync(CommissionQuery parameter);

        /// <summary>
        /// 异步获取佣金
        /// </summary>
        Task<CommissionDto> GetCommissionByIdAsync(Guid guid);

        /// <summary>
        /// 添加佣金
        /// </summary>
        Task<Guid> CreateAsync(CommissionCreateRequest request);

        /// <summary>
        /// 修改佣金
        /// </summary>
        Task UpdateAsync(CommissionUpdateRequest request);

        /// <summary>
        /// 删除佣金
        /// </summary>
        Task DeleteCommission(string ids);

    }
}