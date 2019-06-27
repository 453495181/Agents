using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
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
        public DownloadLogRepository(IAgentsUnitOfWork unitOfWork) : base(unitOfWork) {
        }

        /// <summary>
        /// 根据Ip地址获取下载记录
        /// </summary>
        public async Task<DownloadLog> GetDownloadLogByIp(string iPAddress) {
            iPAddress = iPAddress.Trim();
            var endTime = DateTime.Now.AddDays(-15);
            var result = await Find(t => t.IPAddress == iPAddress && t.CreationTime > endTime).FirstOrDefaultAsync();
            return result;
        }
    }
}