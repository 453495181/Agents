using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Queries.Distributions;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 域名服务
    /// </summary>
    public interface IDomainService : ICrudService<DomainDto, DomainQuery> {
    }
}