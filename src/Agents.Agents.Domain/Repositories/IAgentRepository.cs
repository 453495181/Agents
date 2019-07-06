using System.Threading.Tasks;
using Util.Domains.Repositories;
using Agents.Agents.Domain.Models;

namespace Agents.Agents.Domain.Repositories {
    /// <summary>
    /// 代理仓储
    /// </summary>
    public interface IAgentRepository : IRepository<Agent> {
        /// <summary>
        /// 获取最大Code
        /// </summary>
        Task<int> GetMaxCode();

        /// <summary>
        /// 获取上级代理
        /// </summary>
        Task<Agent> GetParentAgentAsync(Agent agent);
    }
}