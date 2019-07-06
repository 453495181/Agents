using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Queries.Distributions;
using Agents.Service.Abstractions.Distributions;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Distributions {
    /// <summary>
    /// 域名控制器
    /// </summary>
    public class DomainController : QueryControllerBase<DomainDto, DomainQuery> {
        /// <summary>
        /// 初始化域名控制器
        /// </summary>
        /// <param name="service">域名服务</param>
        public DomainController( IDomainService service ) : base( service ) {
            DomainService = service;
        }
        
        /// <summary>
        /// 域名服务
        /// </summary>
        public IDomainService DomainService { get; }

		
        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(DomainQuery query) {
            PagerQueryBefore(query);
            var result = await DomainService.PagerQueryDomainAsync(query);
            return Success(ToPagerQueryResult(result));
        }
		
        /// <summary>
        /// 根据Id获取域名
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await DomainService.GetDomainByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }
				
        /// <summary>
        /// 创建域名
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] DomainCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await DomainService.CreateAsync(request);
            return Success(id);
        }
		 
        /// <summary>
        /// 修改域名
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] DomainUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.DomainId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.DomainId.IsEmpty())
                request.DomainId = id.ToGuid();
            await DomainService.UpdateAsync(request);
            DomainDto byIdAsync = await DomainService.GetByIdAsync(request.DomainId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除域名
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await DomainService.DeleteDomain(id);
            return Success();
        }
		
        /// <summary>
        /// 批量删除域名
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await DomainService.DeleteDomain(ids);
            return Success();
        }
    }
}