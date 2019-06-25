using Util.Domains.Repositories;
using Agents.Distributions.Domain.Models;

namespace Agents.Distributions.Domain.Repositories {
    /// <summary>
    /// 佣金仓储
    /// </summary>
    public interface ICommissionRepository : IRepository<Commission> {
    }
}