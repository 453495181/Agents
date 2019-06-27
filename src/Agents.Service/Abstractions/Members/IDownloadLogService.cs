using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Queries.Members;

namespace Agents.Service.Abstractions.Members {
    /// <summary>
    /// 下载记录服务
    /// </summary>
    public interface IDownloadLogService : ICrudService<DownloadLogDto, DownloadLogQuery> {
	
        /// <summary>
        /// 异步获取下载记录
        /// </summary>
        Task<DownloadLogDto> GetDownloadLogByIdAsync(Guid guid);

        /// <summary>
        /// 添加下载记录
        /// </summary>
        Task<Guid> CreateAsync(DownloadLogCreateRequest request);

        /// <summary>
        /// 修改下载记录
        /// </summary>
        Task UpdateAsync(DownloadLogUpdateRequest request);

        /// <summary>
        /// 删除下载记录
        /// </summary>
        Task DeleteDownloadLog(string ids);

    }
}