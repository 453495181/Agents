using Util.Domains.Repositories;
using Agents.Distributions.Domain.Models;

namespace Agents.Distributions.Domain.Repositories {
    /// <summary>
    /// 域名仓储
    /// </summary>
    public interface IDomainRepository : IRepository<Models.Domain> {
    }
}