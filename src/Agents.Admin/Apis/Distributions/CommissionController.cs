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
    /// 佣金控制器
    /// </summary>
    public class CommissionController : QueryControllerBase<CommissionDto, CommissionQuery> {
        /// <summary>
        /// 初始化佣金控制器
        /// </summary>
        /// <param name="service">佣金服务</param>
        public CommissionController( ICommissionService service ) : base( service ) {
            CommissionService = service;
        }
        
        /// <summary>
        /// 佣金服务
        /// </summary>
        public ICommissionService CommissionService { get; }

		
        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(CommissionQuery query) {
            PagerQueryBefore(query);
            var result = await CommissionService.PagerQueryCommissionAsync(query);
            return Success(ToPagerQueryResult(result));
        }
		
        /// <summary>
        /// 根据Id获取佣金
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await CommissionService.GetCommissionByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }
				
        /// <summary>
        /// 创建佣金
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CommissionCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await CommissionService.CreateAsync(request);
            return Success(id);
        }
		 
        /// <summary>
        /// 修改佣金
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] CommissionUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.CommissionId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.CommissionId.IsEmpty())
                request.CommissionId = id.ToGuid();
            await CommissionService.UpdateAsync(request);
            CommissionDto byIdAsync = await CommissionService.GetByIdAsync(request.CommissionId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除佣金
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await CommissionService.DeleteCommission(id);
            return Success();
        }
		
        /// <summary>
        /// 批量删除佣金
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await CommissionService.DeleteCommission(ids);
            return Success();
        }
    }
}