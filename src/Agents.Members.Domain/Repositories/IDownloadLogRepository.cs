using Util.Domains.Repositories;
using Agents.Members.Domain.Models;
using System.Threading.Tasks;

namespace Agents.Members.Domain.Repositories {
    /// <summary>
    /// 下载记录仓储
    /// </summary>
    public interface IDownloadLogRepository : IRepository<DownloadLog> {

        /// <summary>
        /// 根据Ip地址获取下载记录
        /// </summary>
        Task<DownloadLog> GetDownloadLogByIp(string iPAddress);
    }
}