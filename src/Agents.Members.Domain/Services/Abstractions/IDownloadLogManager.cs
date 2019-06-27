
using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;

namespace Agents.Members.Domain.Services.Abstractions {
    /// <summary>
    /// 下载记录管理器
    /// </summary>
    public interface IDownloadLogManager {

        /// <summary>
        /// 添加下载记录
        /// </summary>
        Task<DownloadLog> CreateDownloadLogAsync(DownloadLog model);
		
        /// <summary>
        /// 删除下载记录
        /// </summary>
        Task DeleteDownloadLog(string ids);
		
        /// <summary>
        /// 修改下载记录
        /// </summary>
        Task UpdateDownloadLog(DownloadLog model);
    }
}