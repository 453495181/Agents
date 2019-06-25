using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Agents.Service.Dtos.Members;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;

namespace Agents.Service.Implements.Members {
    /// <summary>
    /// 下载记录服务
    /// </summary>
    public class DownloadLogService : CrudServiceBase<DownloadLog, DownloadLogDto, DownloadLogQuery>, IDownloadLogService {
        /// <summary>
        /// 初始化下载记录服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="downloadLogRepository">下载记录仓储</param>
        public DownloadLogService( IAgentsUnitOfWork unitOfWork, IDownloadLogRepository downloadLogRepository )
            : base( unitOfWork, downloadLogRepository ) {
            DownloadLogRepository = downloadLogRepository;
        }
        
        /// <summary>
        /// 下载记录仓储
        /// </summary>
        public IDownloadLogRepository DownloadLogRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DownloadLog> CreateQuery( DownloadLogQuery param ) {
            return new Query<DownloadLog>( param );
        }
    }
}