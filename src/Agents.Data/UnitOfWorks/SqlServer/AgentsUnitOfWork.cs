using Microsoft.EntityFrameworkCore;
using Util.Datas.UnitOfWorks;

namespace Agents.Data.UnitOfWorks.SqlServer {
    /// <summary>
    /// 工作单元
    /// </summary>
    public class AgentsUnitOfWork : Util.Datas.Ef.SqlServer.UnitOfWork,IAgentsUnitOfWork {
        /// <summary>
        /// 初始化工作单元
        /// </summary>
        /// <param name="options">配置项</param>
        public AgentsUnitOfWork( DbContextOptions<AgentsUnitOfWork> options ) : base( options ) {
        }
    }
}