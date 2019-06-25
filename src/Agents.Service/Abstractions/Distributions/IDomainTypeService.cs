using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Queries.Distributions;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 域名分类服务
    /// </summary>
    public interface IDomainTypeService : ICrudService<DomainTypeDto, DomainTypeQuery> {
    }
}