using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Repositories;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Services.Abstractions;
using Agents.Members.Domain.Repositories;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Dtos.Members.Extensions;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;
using Microsoft.EntityFrameworkCore;

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
        /// <param name="downloadLogManager">下载记录管理器</param>
        public DownloadLogService(IAgentsUnitOfWork unitOfWork, IDownloadLogRepository downloadLogRepository, IDownloadLogManager downloadLogManager, IAgentRepository agentRepository)
            : base(unitOfWork, downloadLogRepository) {
            UnitOfWork = unitOfWork;
            DownloadLogRepository = downloadLogRepository;
            DownloadLogManager = downloadLogManager;
            AgentRepository = agentRepository;
        }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 下载记录仓储
        /// </summary>
        public IDownloadLogRepository DownloadLogRepository { get; set; }

        /// <summary>
        /// 下载记录管理器
        /// </summary>
        public IDownloadLogManager DownloadLogManager { get; set; }

        public IAgentRepository AgentRepository { get; }


        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DownloadLog> CreateQuery(DownloadLogQuery param) {
            return new Query<DownloadLog>(param);
        }

        /// <summary>
        /// 异步获取下载记录
        /// </summary>
        public async Task<DownloadLogDto> GetDownloadLogByIdAsync(Guid id) {
            var entity = await DownloadLogRepository.FindAsync(id);
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加下载记录
        /// </summary>
        public async Task<Guid> CreateAsync(string agentCode) {
            var agentCodeInt = agentCode.ToIntOrNull();
            var agent = await AgentRepository.Find(t => t.Code == agentCodeInt).FirstOrDefaultAsync();
            var downloadLog = new DownloadLog();
            downloadLog.AgentId = agent?.Id;
            downloadLog.IPAddress = Util.Helpers.Web.Ip;
            downloadLog = await DownloadLogManager.CreateDownloadLogAsync(downloadLog);
            await UnitOfWork.CommitAsync();
            return downloadLog.Id;
        }

        /// <summary>
        /// 修改下载记录
        /// </summary>
        public async Task UpdateAsync(DownloadLogUpdateRequest request) {
            var entity = await DownloadLogRepository.FindAsync(request.DownloadLogId);
            request.MapTo(entity);
            await DownloadLogRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除下载记录
        /// </summary>
        public async Task DeleteDownloadLog(string ids) {
            await DownloadLogManager.DeleteDownloadLog(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}