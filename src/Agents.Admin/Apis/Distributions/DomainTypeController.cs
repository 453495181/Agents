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
    /// 域名分类控制器
    /// </summary>
    public class DomainTypeController : QueryControllerBase<DomainTypeDto, DomainTypeQuery> {
        /// <summary>
        /// 初始化域名分类控制器
        /// </summary>
        /// <param name="service">域名分类服务</param>
        public DomainTypeController( IDomainTypeService service ) : base( service ) {
            DomainTypeService = service;
        }
        
        /// <summary>
        /// 域名分类服务
        /// </summary>
        public IDomainTypeService DomainTypeService { get; }

		
        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(DomainTypeQuery query) {
            PagerQueryBefore(query);
            var result = await DomainTypeService.PagerQueryDomainTypeAsync(query);
            return Success(ToPagerQueryResult(result));
        }
		
        /// <summary>
        /// 根据Id获取域名分类
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await DomainTypeService.GetDomainTypeByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }
				
        /// <summary>
        /// 创建域名分类
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] DomainTypeCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await DomainTypeService.CreateAsync(request);
            return Success(id);
        }
		 
        /// <summary>
        /// 修改域名分类
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] DomainTypeUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.DomainTypeId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.DomainTypeId.IsEmpty())
                request.DomainTypeId = id.ToGuid();
            await DomainTypeService.UpdateAsync(request);
            DomainTypeDto byIdAsync = await DomainTypeService.GetByIdAsync(request.DomainTypeId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除域名分类
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await DomainTypeService.DeleteDomainType(id);
            return Success();
        }
		
        /// <summary>
        /// 批量删除域名分类
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await DomainTypeService.DeleteDomainType(ids);
            return Success();
        }
    }
}