using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace Agents.Data.Repositories.Members {
    /// <summary>
    /// 下载记录仓储
    /// </summary>
    public class DownloadLogRepository : RepositoryBase<DownloadLog>, IDownloadLogRepository {
        /// <summary>
        /// 初始化下载记录仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public DownloadLogRepository( IAgentsUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}