using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Members {
    /// <summary>
    /// 下载记录控制器
    /// </summary>
    public class DownloadLogController : QueryControllerBase<DownloadLogDto, DownloadLogQuery> {
        /// <summary>
        /// 初始化下载记录控制器
        /// </summary>
        /// <param name="service">下载记录服务</param>
        public DownloadLogController( IDownloadLogService service ) : base( service ) {
            DownloadLogService = service;
        }
        
        /// <summary>
        /// 下载记录服务
        /// </summary>
        public IDownloadLogService DownloadLogService { get; }

		
        /// <summary>
        /// 根据Id获取下载记录
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await DownloadLogService.GetDownloadLogByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }
				
        /// <summary>
        /// 创建下载记录
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] DownloadLogCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await DownloadLogService.CreateAsync(request);
            return Success(id);
        }
		 
        /// <summary>
        /// 修改下载记录
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] DownloadLogUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.DownloadLogId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.DownloadLogId.IsEmpty())
                request.DownloadLogId = id.ToGuid();
            await DownloadLogService.UpdateAsync(request);
            DownloadLogDto byIdAsync = await DownloadLogService.GetByIdAsync(request.DownloadLogId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除下载记录
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await DownloadLogService.DeleteDownloadLog(id);
            return Success();
        }
		
        /// <summary>
        /// 批量删除下载记录
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await DownloadLogService.DeleteDownloadLog(ids);
            return Success();
        }
    }
}