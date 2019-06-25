using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Queries.Distributions;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 佣金服务
    /// </summary>
    public interface ICommissionService : ICrudService<CommissionDto, CommissionQuery> {
    }
}