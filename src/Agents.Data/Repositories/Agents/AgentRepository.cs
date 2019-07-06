using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Dapper;
using Util;
using Util.Datas.Ef.Core;
using Util.Datas.Sql;

namespace Agents.Data.Repositories.Agents {
    /// <summary>
    /// 代理仓储
    /// </summary>
    public class AgentRepository : RepositoryBase<Agent>, IAgentRepository {
        /// <summary>
        /// 初始化代理仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AgentRepository(IAgentsUnitOfWork unitOfWork) : base(unitOfWork) {
        }

        /// <summary>
        /// 获取最大Code
        /// </summary>
        public async Task<int> GetMaxCode() {
            var result = await this.Connection.ExecuteScalarAsync("select max(Code) from [Agents].[Agent]");
            if (result == null) {
                return 0;
            }
            return Convert.ToInt32(result);
        }


        /// <summary>
        /// 获取上级代理
        /// </summary>
        public async Task<Agent> GetParentAgentAsync(Agent agent) {
            if (agent == null || !agent.ParentId.HasValue) {
                return null;
            }
            return await FindAsync(agent.ParentId.SafeValue());
        }
    }
}