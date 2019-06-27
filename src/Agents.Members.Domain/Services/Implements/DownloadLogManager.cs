
using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Agents.Members.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Members.Domain.Services.Implements {
    /// <summary>
    /// 下载记录管理器
    /// </summary>
    public class DownloadLogManager : DomainServiceBase, IDownloadLogManager {

		/// <summary>
        /// 初始化下载记录管理器
        /// </summary>
        /// <param name="downloadLogRepository">下载记录仓储</param>
        public DownloadLogManager(IDownloadLogRepository downloadLogRepository){
            DownloadLogRepository = downloadLogRepository;
        }

        /// <summary>
        /// 下载记录仓储
        /// </summary>
        public IDownloadLogRepository DownloadLogRepository { get; set; }

        /// <summary>
        /// 添加下载记录
        /// </summary>
        public async Task<DownloadLog> CreateDownloadLogAsync(DownloadLog model) {
            model.Init();
            await DownloadLogRepository.AddAsync(model);
            return model;
		}
		
        /// <summary>
        /// 修改下载记录
        /// </summary>
        public async Task UpdateDownloadLog(DownloadLog model) {
            throw new NotImplementedException();
		}
		
        /// <summary>
        /// 删除下载记录
        /// </summary>
        public async Task DeleteDownloadLog(string ids) {
            var entitis = await DownloadLogRepository.FindByIdsAsync(ids);
            await DownloadLogRepository.RemoveAsync(entitis);
		}
		
    }
}