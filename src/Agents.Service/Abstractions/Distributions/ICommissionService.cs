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

    }
}