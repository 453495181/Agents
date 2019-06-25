using Util.Applications;
using Agents.Service.Dtos.Members;
using Agents.Service.Queries.Members;

namespace Agents.Service.Abstractions.Members {
    /// <summary>
    /// 下载记录服务
    /// </summary>
    public interface IDownloadLogService : ICrudService<DownloadLogDto, DownloadLogQuery> {
    }
}