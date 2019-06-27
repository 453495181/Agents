using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Agents
{
    /// <summary>
    /// 提现控制器
    /// </summary>
    public class OutCashController : QueryControllerBase<OutCashDto, OutCashQuery>
    {
        /// <summary>
        /// 初始化提现控制器
        /// </summary>
        /// <param name="service">提现服务</param>
        public OutCashController(IOutCashService service) : base(service)
        {
            OutCashService = service;
        }

        /// <summary>
        /// 提现服务
        /// </summary>
        public IOutCashService OutCashService { get; }


        /// <summary>
        /// 根据Id获取提现
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id)
        {
            var byIdAsync = await OutCashService.GetOutCashByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }

        /// <summary>
        /// 创建提现
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OutCashCreateRequest request)
        {
            if (request == null)
            {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await OutCashService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>
        /// 修改提现
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] OutCashUpdateRequest request)
        {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.OutCashId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.OutCashId.IsEmpty())
                request.OutCashId = id.ToGuid();
            await OutCashService.UpdateAsync(request);
            OutCashDto byIdAsync = await OutCashService.GetByIdAsync(request.OutCashId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除提现
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            await OutCashService.DeleteOutCash(id);
            return Success();
        }

        /// <summary>
        /// 批量删除提现
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids)
        {
            await OutCashService.DeleteOutCash(ids);
            return Success();
        }
    }
}